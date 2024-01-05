using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "IconStorage", menuName = "Storage/IconStorage", order = 1)]
public class SpriteStorage : ScriptableObject

{
    [SerializeField] List<VisualElement> elements;

    public Sprite GetVisual(string key)
    {
        elements.FirstOrDefault(x => x.Id == key);
       
        Debug.LogWarning($"In {GetType()} key " + key + " not found."); 
        return default;
    }
}
