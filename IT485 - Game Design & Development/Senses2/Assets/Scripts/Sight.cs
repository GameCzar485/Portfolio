using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sight : Sense
{
    public int FieldOfView = 45;
    public int ViewDistance = 100;

    private Transform playerTransform;
    private Vector3 rayDirection;

    public override void Initialize() {

        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

    }

    public override void UpdateSense() {

        elapsedTime = elapsedTime + Time.deltaTime;
        if(elapsedTime >= detectionRate)
        {

            DetectAspect();
        }

    }

    public void DetectAspect()
    {
        RaycastHit hit;

        rayDirection = playerTransform.position - transform.position;

        if((Vector3.Angle(rayDirection, transform.forward)) < FieldOfView)
        {
            if(Physics.Raycast(transform.position, rayDirection, out hit, ViewDistance))
            {
                Aspect aspect = hit.collider.GetComponent<Aspect>();

                if (aspect != null)
                {
                    if(aspect.aspectName == aspectName)
                    {
                        // This is where you would link to the strategy pattern
                        // or state pattern
                        // that is, you would change the monster's behavior here
                        GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                    }
                }
            }
        }
    }
}
