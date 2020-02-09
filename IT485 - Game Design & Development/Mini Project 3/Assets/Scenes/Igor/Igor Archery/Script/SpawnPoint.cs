using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    float timeLeft = 2.0f;
    public float repeatTime = 3f;

    public GameObject prefab;

    void Start()
    {
        InvokeRepeating("Spawn", 2f, repeatTime);
    }

    void Spawn ()
    {
       
        Instantiate(prefab, transform.position, Quaternion.identity);
        
    }
}
