using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelView : MonoBehaviour
{
    [SerializeField] private TMP_Text displayLevel;

    private void Start()
    {
        PlayerModel.Instance.OnPlayerModelChanged += UpdateLevel;
        UpdateLevel();
    }

    private void UpdateLevel()
    {
        int level = PlayerModel.Instance.CurrentLevel;
        displayLevel.text = "Level: " + level.ToString();
    }

    private void OnDestroy()
    {
        PlayerModel.Instance.OnPlayerModelChanged -= UpdateLevel;
    }

}
