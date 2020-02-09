﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    private int health;
    private int healthMax;
    public HealthSystem(int healthMax){
        this.healthMax = healthMax;
        health = healthMax;

    }

    public int GetHealth() {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
        if (health < 0) health = 0;
    }

    public void Heal(int healAmount)
    {
        health += healAmount;
        if (health > healthMax) health = healthMax;
    }
 

    

}