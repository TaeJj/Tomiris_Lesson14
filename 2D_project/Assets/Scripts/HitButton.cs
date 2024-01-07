using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class HitButton : MonoBehaviour
{
    

    void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(DealDamage);
    }


    private void DealDamage()
    {
        MobModel.Instance.TakeDamage(PlayerModel.Instance.Damage);
    }
}
