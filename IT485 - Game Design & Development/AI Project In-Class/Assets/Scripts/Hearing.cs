using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearing : Sense
{
    public int FOH = 360;
    public float hearingDistance = 10;

    private float dista;

    private Transform alarmTransform;
    private Vector3 rayDirection;

    public override void Initialize()
    {
        alarmTransform = GameObject.FindGameObjectWithTag("Alarm").transform;
    }

    public override void UpdateSense()
    {
        elapsedTime = elapsedTime + Time.deltaTime;
        if (elapsedTime >= detectRate)
        {
            DetectAspect();
        }
    }

    public void DetectAspect()
    {
        dista = Vector3.Distance(transform.position, alarmTransform.position);
        if (dista <= hearingDistance)
        {
            if (GameObject.FindGameObjectWithTag("Alarm").GetComponent<Alarm>().isActive == true)
            {
                GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
