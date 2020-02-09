using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{
    private Vector3 targetPosition;

    private float rotationSpeed = 2.0f;
    private float movementSpeed = 2.0f;
    private float minX;
    private float maxX;
    private float minZ;
    private float maxZ;

    // Start is called before the first frame update
    void Start()
    {
        minX = -25;
        maxX = 25;
        minZ = -25;
        maxZ = 25;
        GetNextPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(targetPosition, transform.position) <= 2.0f)
        {
            GetNextPosition();
        }

        Quaternion targetRotation = Quaternion.LookRotation(targetPosition - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime));
    }




    private void GetNextPosition()
    {

        targetPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));

    }
}
