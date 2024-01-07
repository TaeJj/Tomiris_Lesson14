using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LevelSelector : MonoBehaviour
{
    DataProvider dataProvider = new DataProvider();
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(LoadActualLevel);
        button.interactable = dataProvider.PlayerJSONExist();
    }
    public void LoadActualLevel()
    {
        var level = PlayerModel.Instance.CurrentLevel+1;
        SceneManager.LoadScene(level);
    }
}
