using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        inY = Input.GetAxis("Jump");
        inZ = Input.GetAxis("Vertical");

        rigid.velocity = new Vector3(inX * speed, rigid.velocity.y, inZ * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.velocity = new Vector3(inX * speed, inY * speed, inZ * speed);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            rigid.velocity = new Vector3(inX * speed, inY * speed, inZ * speed);
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
