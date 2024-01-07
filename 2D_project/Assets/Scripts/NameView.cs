using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class NameView : MonoBehaviour
{
    [SerializeField] public TMP_Text displayName;

    private void Start()
    {
        MobModel.Instance.OnMobChanged += Setup;

        Setup();
    }
    public void Setup()
    {
        string name = MobModel.Instance.Id;
        displayName.text = name;
    }

    private void OnDestroy()
    {
        MobModel.Instance.OnMobChanged -= Setup;
    }
}

  
