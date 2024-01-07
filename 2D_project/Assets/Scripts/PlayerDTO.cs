using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerDTO
{
    public int CurrentLevel;
    public int Score;
    public int Damage;

    public PlayerDTO(int currentLevel, int score, int damage)
    {
        CurrentLevel = currentLevel;
        Score = score;
        Damage = damage;
    }
}
