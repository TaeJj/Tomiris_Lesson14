using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameState : MonoBehaviour
{
    [SerializeField] MobStorage MobStorage;
    private DataProvider dataProvider = new DataProvider();

    private void Start()
    {
        Initialize();
        MobModel.Instance.OnMobDamage += CheckMainMobState;

        DontDestroyOnLoad(gameObject);
    }

   private void CheckMainMobState() 
    { 
     if (MobModel.Instance.HealthPoints <= 0)
        {
            ChangeMob();
        }
    
    }

    private void ChangeMob()
    {
        var mob = MobStorage.GetNextMob(MobModel.Instance.Id);
        MobModel.Instance.Initialize(mob);

    }

    private void OnApplicationQuit()
    {
     dataProvider.SavePlayerToJson(PlayerModel.Instance.ToDTO());
     dataProvider.SaveMobToJson(MobModel.Instance.ToDTO());
    }

    public void Initialize()
    {
        var mobData = dataProvider.LoadMobFromJson();
        var playerData = dataProvider.LoadPlayerFromJson();
        mobData ??= MobStorage.Elements.First();
        Debug.Log(playerData.Damage);
        if (playerData.Damage == 0)
        {
            playerData.Damage = 10;
        }
        Debug.Log(playerData.Damage);
        MobModel.Instance.Initialize(mobData);
        PlayerModel.Instance.Initialize(playerData);
        

    }
}
     
