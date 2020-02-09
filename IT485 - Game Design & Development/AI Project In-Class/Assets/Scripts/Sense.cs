using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sense : MonoBehaviour
{

    public Aspect.aspect aspectName = Aspect.aspect.Enemy;
    public float detectRate = 1.0f;
    public float elapsedTime = 0.0f;

    // This will be called in the concrete class' Start() method
    public virtual void Initialize()
    {

    }
    // This will be called in the concrete class' Update() method
    public virtual void UpdateSense()
    {

    }



    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0.0f;
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSense();
    }
}
