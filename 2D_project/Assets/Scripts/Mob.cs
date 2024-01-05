using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Mob 
{
    public string Id;
    public int HealthPoints;
    

    public Mob(string mobId, int healthPoints)
    {
        Id = mobId;
        HealthPoints = healthPoints;
    }
}
