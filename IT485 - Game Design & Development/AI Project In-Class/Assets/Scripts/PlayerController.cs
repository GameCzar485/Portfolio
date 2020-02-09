using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Transform target;
    public float speed;
    public float rotSpeed;
    

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < 5.0f)
        {
            return;
        }

        Vector3 targetPos = target.position;
        Vector3 directionRot = targetPos - transform.position;

        Quaternion targetRot = Quaternion.LookRotation(directionRot);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot,rotSpeed * Time.deltaTime);

        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

    }
}
