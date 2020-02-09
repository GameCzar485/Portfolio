using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character2 : MonoBehaviour
{

    public Rigidbody rigid;
    public Renderer rend;
    public float speed;
    private float inX;
    private float inY;
    private float inZ;
    private GameObject NPC;
    public GameObject spwn;


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

        if (Input.GetKeyDown(KeyCode.J))
        {
            SceneManager.LoadScene("Scene1");
        }

        NPC = GameObject.FindGameObjectWithTag("NPC");

        if (Vector3.Distance(transform.position, NPC.transform.position) > 2)
        {
            rend.material.color = Color.green;
        }

        if (Vector3.Distance(transform.position, NPC.transform.position) < 2 && Vector3.Distance(transform.position, NPC.transform.position) > 1)
        {
            rend.material.color = Color.yellow;
        }

        if (Vector3.Distance(transform.position, NPC.transform.position) < 1)
        {
            rend.material.color = Color.red;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(spwn);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Barrier")
        {
            transform.position = new Vector3(0, 0.5f, 0);
        }
    }
}