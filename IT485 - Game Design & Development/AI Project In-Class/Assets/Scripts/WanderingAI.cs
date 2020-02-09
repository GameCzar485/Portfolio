using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderingAI : MonoBehaviour
{
    private Vector3 targetPos;
    private float rotSpeed = 2.0f;
    private float speed = 2.0f;
    private float minX;
    private float maxX;
    private float minZ;
    private float maxZ;
    void Start()
    {
        minX = -20;
        maxX = 20;
        minZ = -20;
        maxZ = 20;
        GetNextPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(targetPos, transform.position) <= 2.0f)
        {
            GetNextPosition();
        }
        
        Quaternion targetRot = Quaternion.LookRotation(targetPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotSpeed * Time.deltaTime);
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        
    }


    private void GetNextPosition()
    {
        targetPos = new Vector3(Random.Range(minX, maxX), transform.position.y, Random.Range(minZ, maxZ));
    }
}
