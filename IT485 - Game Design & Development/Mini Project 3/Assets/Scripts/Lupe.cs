using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lupe : MonoBehaviour
{
    public float speed;
    private Vector3 origin;
    private Vector3 moveTo;
    private int trackNum;
    void Start()
    {
        origin = new Vector3(transform.position.x, transform.position.y + 5, transform.position.z);
        moveTo = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        speed = speed * Random.Range(1.0f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(origin, moveTo, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
    }
}
