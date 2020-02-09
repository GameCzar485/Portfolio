using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerminateTimer : MonoBehaviour
{
    private int count = 0;
    private float start;
    private float now;
    private float end;

    void Start()
    {
        start = Time.time;
        end = start + 6;
    }

    // Update is called once per frame
    void Update()
    {
        now = Time.time;
        if (now > end)
        {
            Destroy(gameObject);
        }
    }
}
