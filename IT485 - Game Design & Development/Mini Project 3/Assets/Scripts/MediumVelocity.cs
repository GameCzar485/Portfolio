using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumVelocity : IVelocity
{
    float velocity = 40;

    public float ThrowVelocity()
    {
        return this.velocity;
    }

}
