using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{
    public GameObject dodgeball;
    public float throwspeed = 100f;

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBall = Instantiate(dodgeball, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBallRigidBody = instBall.GetComponent<Rigidbody>();
            instBallRigidBody.AddForce(Vector3.forward * throwspeed);
            Destroy(this.gameObject, 2.0f);
            Destroy(this.dodgeball, 2.0f);
            Destroy(instBall, 2.0f);
            Destroy(instBallRigidBody, 2.0f);
        }
        Destroy(dodgeball, 5.0f);
    }
   
}
