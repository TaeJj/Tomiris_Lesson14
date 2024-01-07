using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MobModel : MonoBehaviour
{
    public string Id;
    public int HealthPoints;
    public int MaxHealthPoints;
    public static MobModel Instance { get; private set; }
   

    public event Action OnMobDamage;
    public event Action OnMobChanged;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void TakeDamage( int damageAmount)
    {
        HealthPoints -= damageAmount;
        OnMobDamage?.Invoke();

    }

    

    public void Initialize(MobDTO mobDTO)

    {
        Id = mobDTO.Id;
        HealthPoints = mobDTO.HealthPoints;
        MaxHealthPoints = mobDTO.MaxHealthPoints;
        OnMobChanged?.Invoke();
       
    }

    public MobDTO ToDTO()
    {
        MobDTO mobDTO = new MobDTO(Id, HealthPoints, MaxHealthPoints);
        return mobDTO;
    }
}
