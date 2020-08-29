using UnityEngine;
using LitJson;
using System.IO;

public class DataManager : MonoBehaviour
{
    public JsonData items;

    void Awake()
    {
        LoadData();
    }

    public void LoadData()
    {
        items = JsonMapper.ToObject(File.ReadAllText(Application.streamingAssetsPath + "/JsonChallenge.json"));
    }
}
