using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastVelocity : IVelocity
{
    float velocity = 80;

    public float ThrowVelocity()
    {
        return this.velocity;
    }

}
