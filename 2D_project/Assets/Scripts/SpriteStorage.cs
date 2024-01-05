using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IconStorage", menuName = "Storage/IconStorage", order = 1)]
public class SpriteStorage : ScriptableObject

{
    [SerializeField] List<VisualElement> elements;

}
