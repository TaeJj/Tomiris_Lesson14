using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataProvider
{
    private string playerDataPath => Application.persistentDataPath + "/player.json";
    private string mobDataPath => Application.persistentDataPath + "/mob.json";

    public MobDTO LoadMobFromJson()
    {
       
        if (File.Exists(mobDataPath))
        {
            string json = File.ReadAllText(mobDataPath);
            MobDTO mobData = JsonUtility.FromJson<MobDTO>(json);
            return mobData;
        }
        else
        {
            Debug.LogWarning("Mob data file does not exist.");
            return default;
        }
    }

    public void SaveMobToJson(MobDTO mob)
    {
        
        string json = JsonUtility.ToJson(mob);
        File.WriteAllText( mobDataPath, json);
       
    }

    public PlayerDTO LoadPlayerFromJson()
    {
        
        if (File.Exists(playerDataPath))
        {
            string json = File.ReadAllText(playerDataPath);
            PlayerDTO playerData = JsonUtility.FromJson<PlayerDTO>(json);
            return playerData;
        }
        else
        {
            Debug.LogWarning("Player data file does not exist.");
            return default;
        }
    }

    public void SavePlayerToJson(PlayerDTO player)
    {
        
        string json = JsonUtility.ToJson(player);
        File.WriteAllText(playerDataPath, json);
    }

    public void Clear()
    {
        if (File.Exists(mobDataPath))
        {
            File.Delete(mobDataPath);
        }
        else
        {
            Debug.LogWarning("File not exist: " + mobDataPath);
        }

        if (File.Exists(playerDataPath))
        {
            File.Delete(playerDataPath);
        }
        else
        {
            Debug.LogWarning("File not exist: " + playerDataPath);
        }
    }

    public bool PlayerJSONExist()
    {
        return File.Exists(playerDataPath);
    }
}

