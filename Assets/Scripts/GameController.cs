using UnityEngine;
using System.IO;
using System.Collections;

public class GameController : MonoBehaviour
{
    private string filePath = Application.streamingAssetsPath + "/BDCondecorados.txt";
    private string result = "";

    public string[][] dataPlayers = new string[1504][];
    private string[] dataList = new string[1504];

    public string userID;
    //public string userName;
    public string personID;

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

    public void VideoPlayer(int a)
    {
        switch (a)
        {
            case 0:
                Application.ExternalCall("trigger_streaming", "m-streaming");
                break;
            case 5:
                Application.ExternalCall("trigger_cinco", "m-cinco");
                break;
            case 10:
                Application.ExternalCall("trigger_diez", "m-diez");
                break;
            case 15:
                Application.ExternalCall("trigger_quince", "m-quince");
                break;
            case 20:
                Application.ExternalCall("trigger_veinte", "m-veinte");
                break;
            case 25:
                Application.ExternalCall("trigger_veinticinco", "m-veinticinco");
                break;
            case 30:
                Application.ExternalCall("trigger_treinta", "m-treinta");
                break;
            default:
                break;
        }
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
            //problems 
            print(w.error);
        }

        Application.ExternalCall("trigger_muro", userID, personID, "g67HsR1ockT5dsF");
    }
}


