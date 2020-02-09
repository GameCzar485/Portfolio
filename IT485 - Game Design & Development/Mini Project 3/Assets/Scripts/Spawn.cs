using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject targetPrefab;
    [SerializeField] private GameObject mTargetPrefab;
    [SerializeField] private GameObject vTargetPrefab;
    private GameObject target;
    public int targetMax;
    private GameObject[] gol;
    private int targetCounter = 0;
    private int rn = 2;


    void Update()
    {
        gol = GameObject.FindGameObjectsWithTag("Target");
        targetCounter = gol.Length;
        if (targetCounter == 0)
        {
            for (int i = 0; i < targetMax; i++)
            {
                if (rn == 1)
                {
                    target = Instantiate(targetPrefab) as GameObject;
                    rn = 2;
                    target.transform.position = new Vector3(Random.Range(-620, -580),
                                                            Random.Range(2, 15),
                                                            Random.Range(140, 160));
                }
                if (rn == 2)
                {
                    target = Instantiate(mTargetPrefab) as GameObject;
                    rn = 3;
                    target.transform.position = new Vector3(Random.Range(-620, -580),
                                                            Random.Range(2, 15),
                                                            Random.Range(140, 160));
                }
                if (rn == 3)
                {
                    target = Instantiate(vTargetPrefab) as GameObject;
                    rn = 1;
                    target.transform.position = new Vector3(Random.Range(-620, -580),
                                                            Random.Range(2, 15),
                                                            Random.Range(140, 160));
                }
            }
        }
    }
}
