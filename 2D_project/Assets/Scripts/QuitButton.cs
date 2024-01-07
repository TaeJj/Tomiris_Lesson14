using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class QuitButton : MonoBehaviour
{

    private void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(QuitApplication);
    }
    public void QuitApplication()
    {
        Application.Quit();
    }
}
