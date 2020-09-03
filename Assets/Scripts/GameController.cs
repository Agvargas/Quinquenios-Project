using UnityEngine;
using System.IO;
using System.Collections;

public class GameController : MonoBehaviour
{
    private string filePath = Application.streamingAssetsPath + "/BDCondecorados.txt";
    private string result = "";

    public string[][] dataPlayers = new string[1444][];
    private string[] dataList = new string[1444];

    public int userID;

    void Awake()
    {
        filePath = Application.streamingAssetsPath + "/BDCondecorados.txt";
    }

    void Start()
    {
        StartCoroutine(userDetailsXmlPath(filePath));
        
    }

    IEnumerator userDetailsXmlPath(string a)
    {
        if (a.Contains("://") || a.Contains(":///"))
        {
            WWW www = new WWW(a);
            yield return www;
            result = www.text;
        }
        else
        {
            result = File.ReadAllText(a);
        }
        print(result);
        LoadData();
    }

    void LoadData()
    {
        string[] a = result.Split('/');
        for (int i = 0; i < dataList.Length; i++)
        {
            dataList[i] = a[i];
        }

        for (int i = 0; i < dataPlayers.Length; i++)
        {
            dataPlayers[i] = dataList[i].Split(';');
        }
    }
}


