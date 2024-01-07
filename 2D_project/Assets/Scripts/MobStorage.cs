using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


[CreateAssetMenu(fileName = "MobStorage", menuName = "Storage/MobStorage", order = 1)]
public class MobStorage : ScriptableObject
{
    [SerializeField] List<MobDTO> elements;

    public IReadOnlyList<MobDTO> Elements => elements;
    public MobDTO GetMob(string key)
    {
        return elements.FirstOrDefault(x => x.Id == key);
    }

    public MobDTO GetNextMob(string key)
    {
        
        for (int i = 0; i < elements.Count; i++)
        {
            if (i == elements.Count - 1)
            {
                return elements[1];
            }


            if (elements[i].Id == key)
            {
               return elements[i+1];
            }

        }

        throw new System.Exception("Invalid Key");
    }
}
