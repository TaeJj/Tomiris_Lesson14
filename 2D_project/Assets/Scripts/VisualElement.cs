using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

[Serializable]
public class VisualElement
{
    public string Id;
    public Sprite sprite;

    public VisualElement(string id, Sprite sprite)
    {
        Id = id;
        this.sprite = sprite;
    }
}



    

