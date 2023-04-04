using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataSaveLoad
{
    public void Load<T>(string keyname, ref T data)
    {
        string json = PlayerPrefs.GetString(keyname, "{}");
        JsonUtility.FromJsonOverwrite(json, data);
    }

    public void Save(string keyname, object data)
    {
        string json = JsonUtility.ToJson(data);
        PlayerPrefs.SetString(keyname, json);
    }
    public void Clear(string keyname)
    {
        PlayerPrefs.DeleteKey(keyname);
    }
}
