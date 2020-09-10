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
    public int personID;

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

    public void VideoPlayer()
    {
        Application.ExternalCall("trigger_streaming", "m-streaming");

        print("play video!!!");
    }

    public void ActiveMessenger()
    {
        StartCoroutine(Messenger("https://www.quinqueniosfgs.com/app/mensajes.php"));
    }

    IEnumerator Messenger(string a)
    {
        WWWForm form = new WWWForm();
        form.AddField("idusuario_de", userID);
        form.AddField("idusuario_para", personID);
        form.AddField("accesskey", "g67HsR1ockT5dsF");
        WWW w = new WWW(a, form);
        yield return w;
        
        print(w.text);
        print("id_de_: " + userID);
        print("id_para_: " + personID);

        if (w.error != null)
        {
            //problemas 
            print(w.error);
        }
    }
}


