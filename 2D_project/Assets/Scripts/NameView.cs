using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameView : MonoBehaviour
{
    [SerializeField] public Text displayName;

    public void Display(string name)
    {
        displayName.text = name;
    }
}
  
