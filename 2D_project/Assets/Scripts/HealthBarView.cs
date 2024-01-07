using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarView : MonoBehaviour
{
    [SerializeField] private Image healthImage;

    

    private void Update()
    {
        float fillAmount = (float)MobModel.Instance.HealthPoints / MobModel.Instance.MaxHealthPoints;
        healthImage.fillAmount = fillAmount;
    }

}
