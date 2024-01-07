using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class HealthPointsView
{
    [SerializeField] private TMP_Text healthText;

    private void Start()
    {
        UpdateHealthPoints();
        MobModel.Instance.OnMobDamage += UpdateHealthPoints;
        MobModel.Instance.OnMobChanged += UpdateHealthPoints;
    }

    private void UpdateHealthPoints()
    {
        healthText.text = "Health: " + MobModel.Instance.HealthPoints.ToString();
    }

    private void OnDestroy()
    {
        MobModel.Instance.OnMobDamage -= UpdateHealthPoints;
        MobModel.Instance.OnMobChanged -= UpdateHealthPoints;
    }
}

