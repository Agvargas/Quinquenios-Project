using UnityEngine;
using System.IO;
using System;
using System.Text;
using LitJson;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GameController : MonoBehaviour
{

    public string filePath = Application.streamingAssetsPath + "/BDCondecorados.txt";
    public string filePath2 = Application.streamingAssetsPath + "/BDCondecoradosArray.json";
    public string result = "";

    public string[][] dataPlayers = new string[1309][];
    //private string[] dataList = new string[1309];

    public int userID;

    void Awake()
    {
        filePath = Application.streamingAssetsPath + "/BDCondecorados.txt";
        filePath2 = Application.streamingAssetsPath + "/BDCondecoradosArray.json";
    }

    void Start()
    {
        StartCoroutine(userDetailsXmlPath(filePath));
        StartCoroutine(userDetailsXmlPath(filePath2));
        LoadData();
        //dataList = File.ReadAllLines(result, Encoding.UTF7);

        //for (int i = 0; i < dataPlayers.Length; i++)
        //{
        //    dataPlayers[i] = dataList[i].Split(';');
        //}
    }

    IEnumerator userDetailsXmlPath(string a)
    {
        print(a);

        if (a.Contains("://") || a.Contains(":///"))
        {
            WWW www = new WWW(a);
            yield return www;
            result = www.text;

            print(result);
        }
        else
        {
            result = File.ReadAllText(a);

            print(result);
        }
    }











    //public string[] dataList2 = new string[1];
    //private TextAsset dataText;




    public JsonData items;

    //void Awake()
    //{
    //    LoadData();
    //}

    public void LoadData()
    {
        items = JsonMapper.ToObject(result);
        print("hello");
        print(items[0][0]);
        print(items[1][0]);
    }

    //void Start()
    //{
    //dataText = Resources.Load("BDCondecoradosArray") as TextAsset;
    //string unicodeString = dataText.text;


    ////// Create two different encodings.
    ////Encoding ascii = Encoding.UTF7;
    ////Encoding unicode = Encoding.UTF8;

    ////// Convert the string into a byte array.
    ////byte[] unicodeBytes = unicode.GetBytes(unicodeString);

    ////// Perform the conversion from one encoding to the other.
    ////byte[] asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

    ////// Convert the new byte[] into a char[] and then into a string.
    ////char[] asciiChars = new char[ascii.GetCharCount(asciiBytes, 0, asciiBytes.Length)];
    ////ascii.GetChars(asciiBytes, 0, asciiBytes.Length, asciiChars, 0);
    ////string asciiString = new string(asciiChars);

    ////// Display the strings created before and after the conversion.
    //print("Original string: "+ unicodeString);
    ////print("Ascii converted string: "+ asciiString);

    //for (int i = 0; i < dataList2.Length; i++)
    //{
    //    //dataList2[i] = unicodeString.Split('/');

    //}


    //}
}


