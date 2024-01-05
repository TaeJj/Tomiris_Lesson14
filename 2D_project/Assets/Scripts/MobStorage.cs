using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(fileName = "MobStorage", menuName = "Storage/MobStorage", order = 1)]
public class MobStorage : ScriptableObject
{
    [SerializeField] List<Mob> elements;

    public Mob GetMob(string key)
    {
        return elements.FirstOrDefault(x => x.Id == key);
    }
}
