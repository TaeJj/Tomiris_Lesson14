using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DummyLevelChanger : MonoBehaviour
{
    private string actualMobId;
    int currentLevel => PlayerModel.Instance.CurrentLevel;
    void Awake()
    {
        actualMobId = MobModel.Instance.Id;
    }

    
    private void Update()
    {
        if (actualMobId == MobModel.Instance.Id) return;
        

        PlayerModel.Instance.ChangeLevel(currentLevel + 1);
        SceneManager.LoadScene(currentLevel+1);

        actualMobId = MobModel.Instance.Id;
    }

    
}
