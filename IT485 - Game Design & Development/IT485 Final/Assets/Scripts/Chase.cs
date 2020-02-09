using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    private GameObject target;
    private NavMeshAgent s;
    private GameObject spwn;

    void Start()
    {
        s = GetComponent<NavMeshAgent>();

        spwn = GameObject.FindGameObjectWithTag("SP");

        transform.position = spwn.transform.position;

        target = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        s.SetDestination(target.transform.position);

        if (Vector3.Distance(transform.position, target.transform.position) < 1)
        {
            Destroy(gameObject);
        }
    }
}
