using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject ball;
    private float x;
    private float z;
    private Vector3 point;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(ball);
            x = Random.Range(-2, 2);
            z = Random.Range(-2, 2);
            point = new Vector3(x, transform.position.y, z);
            transform.position = point;
        }
    }
}
