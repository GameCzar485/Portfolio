using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody rg;
    public Renderer rd;
    public float moveSpeed;
    private float inX2;
    private float inY2;
    private float inZ2;
    private bool dest = false;


    void Start()
    {
        rd = GetComponent<Renderer>();
        rd.material.color = Color.green;

        rg = GetComponent<Rigidbody>();
        rg.velocity = new Vector3(1, 3, 1);
    }


    void Update()
    {
        inX2 = Input.GetAxis("Horizontal");
        inY2 = Input.GetAxis("Jump");
        inZ2 = Input.GetAxis("Vertical");

        rg.velocity = new Vector3(inX2 * moveSpeed, rg.velocity.y, inZ2 * moveSpeed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rg.velocity = new Vector3(inX2 * moveSpeed, inY2 * moveSpeed, inZ2 * moveSpeed);
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            rg.velocity = new Vector3(inX2 * moveSpeed, inY2 * moveSpeed, inZ2 * moveSpeed);
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "RedPower")
        {
            rd.material.color = Color.red;
            dest = true;
        }

        else if (col.collider.tag == "GreenPower")
        {
            rd.material.color = Color.green;
            dest = false;
        }

        if (col.collider.tag == "Ball")
        {
            if (dest == true)
            {
                Destroy(col.collider);
            }
        }
    }
}
