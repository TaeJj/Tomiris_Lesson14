using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPointView : MonoBehaviour
{
    public int healthPoints;
    void Start()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        healthPoints -= damageAmount;
    }
}
    
