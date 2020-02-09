using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowVelocity : IVelocity
{
    float velocity = 20;

    public float ThrowVelocity()
    {
        return this.velocity;
    }

}
