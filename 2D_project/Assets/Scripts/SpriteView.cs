using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteView : MonoBehaviour
{
    [SerializeField] public Image DisplayImage;
    [SerializeField] SpriteStorage storage;
    private void Start()
    {
        MobModel.Instance.OnMobChanged += Setup;
        Setup();
    }

    
    public void Setup()
    {
        string spriteId = MobModel.Instance.Id; 
        DisplayImage.sprite = storage.GetImage(spriteId);
    }

    private void OnDestroy()
    {
        MobModel.Instance.OnMobChanged -= Setup;
    }
}
