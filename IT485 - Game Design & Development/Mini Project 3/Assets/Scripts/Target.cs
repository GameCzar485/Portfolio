using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour
{
    public static int hitCount = 0;
    public TextMeshProUGUI HitCounter;

    private void OnCollisionEnter(Collision col)
    {
        hitCount++;
        Debug.Log("HitCount: " + hitCount);
        Destroy(gameObject);
    }

    void Update()
    {
        HitCounter.text = "HIT COUNT: " + hitCount;
    }
}
