using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Transform targetTransform;
    public float movementSpeed = 2.0f;
    public float rotationSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, targetTransform.position)< 5.0f)
        {
            return;
        }

        Vector3 targetPosition = targetTransform.position;
        Vector3 directionRotation = targetPosition - transform.position;

        Quaternion targetRotation = Quaternion.LookRotation(directionRotation);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, movementSpeed * Time.deltaTime));
        
    }
}
