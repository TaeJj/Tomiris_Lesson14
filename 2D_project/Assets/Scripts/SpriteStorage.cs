using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "IconStorage", menuName = "Storage/IconStorage", order = 1)]
public class SpriteStorage : ScriptableObject

{
    [SerializeField] List<VisualElement> elements;

    public Sprite GetImage(string key)
    {
        return elements.FirstOrDefault(x => x.Id == key).sprite;
       
    }
}
