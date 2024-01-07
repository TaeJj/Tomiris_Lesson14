using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    [SerializeField] private TMP_Text displayScore;

    private void Start()
    {
        PlayerModel.Instance.OnPlayerModelChanged += UpdateScore;
        UpdateScore();
    }

    private void UpdateScore()
    {
        int score = PlayerModel.Instance.Score;
        displayScore.text = "Score: " + score.ToString();
    }

    private void OnDestroy()
    {
        PlayerModel.Instance.OnPlayerModelChanged -= UpdateScore;
    }
}
