using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MobDTO
{
    public string Id;
    public int HealthPoints;
    public int MaxHealthPoints;

    public MobDTO(string id, int healthPoints, int maxHealthPoints)
    {
        Id = id;
        HealthPoints = healthPoints;
        MaxHealthPoints = maxHealthPoints;
    }
}
