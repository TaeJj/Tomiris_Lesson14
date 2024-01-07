using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class NewGameButton : MonoBehaviour
{
    [SerializeField] GameState gameState;
    DataProvider dataProvider = new DataProvider();
    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(PlayNewGame);
    }
    public void PlayNewGame()
    {
      dataProvider.Clear();
        gameState.Initialize();
      SceneManager.LoadScene(1);
    }
}
