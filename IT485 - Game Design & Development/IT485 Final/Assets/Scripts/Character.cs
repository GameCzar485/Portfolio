using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{

    public Rigidbody rigid;
    public Renderer rend;
    public float speed;
    private float inX;
    private float inY;
    private float inZ;


    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = Color.green;

        rigid = GetComponent<Rigidbody>();
        rigid.velocity = new Vector3(1, 3, 1);

    }


    void Update()
    {
        inX = Input.GetAxis("Horizontal");
        inZ = Input.GetAxis("Vertical");
        inY = Input.GetAxis("Jump");

        rigid.velocity = new Vector3(inX * speed, rigid.velocity.y, inZ * speed);

        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.5)
        {
            rigid.velocity = new Vector3(inX * speed, inY * speed, inZ * speed);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            rigid.useGravity = false;
            rend.material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            rigid.useGravity = true;
            rend.material.color = Color.green;
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            SceneManager.LoadScene("Scene2");
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "RedPower")
        {
            rigid.useGravity = false;
            rend.material.color = Color.red;
        }

        else if (col.collider.tag == "GreenPower")
        {
            rigid.useGravity = true;
            rend.material.color = Color.green;
        }
    }
}