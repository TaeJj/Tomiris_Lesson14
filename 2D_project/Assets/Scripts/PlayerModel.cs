using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
        public static PlayerModel Instance { get; private set; }

        public int CurrentLevel;
        public int Score;
        public int Damage;
    
        public event Action OnPlayerModelChanged;
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

    private void Start()
    {
        MobModel.Instance.OnMobDamage += UpdateScore;
    }
    public void AddScore(int pointsToAdd)
        {
            Score += pointsToAdd;
            OnPlayerModelChanged?.Invoke();
        }
    
        public void ChangeLevel(int newLevel)
        {
            CurrentLevel = newLevel;
            OnPlayerModelChanged?.Invoke();
        }


        public void Initialize(PlayerDTO playerDTO)
        {
            CurrentLevel = playerDTO.CurrentLevel;
            Score = playerDTO.Score;
            Damage = playerDTO.Damage;
            OnPlayerModelChanged?.Invoke();
        }
    private void UpdateScore()
    {
        AddScore(Damage);
    }

    public PlayerDTO ToDTO()
    {
        PlayerDTO playerDTO = new PlayerDTO(CurrentLevel, Score, Damage);
        return playerDTO;
    }
}

        

       

        
    
