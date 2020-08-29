using UnityEngine;
using System.IO;
using System;
using System.Text;
using LitJson;

public class GameController : MonoBehaviour
{
    public string[][] dataPlayers = new string[1309][];
    private string[] dataList = new string[1309];
    //public string[] dataList2 = new string[1];
    //private TextAsset dataText;

    public int userID;


    public JsonData items;

    void Awake()
    {
        LoadData();
    }

    public void LoadData()
    {
        items = JsonMapper.ToObject(File.ReadAllText(Application.streamingAssetsPath + "/BDCondecoradosArray.json"));
    }

    void Start()
    {
        //dataText = Resources.Load("BDCondecoradosArray") as TextAsset;
        //string unicodeString = dataText.text;
        dataList = File.ReadAllLines(Application.streamingAssetsPath + "/BDCondecorados.txt", Encoding.UTF7);
        
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

        for (int i = 0; i < dataPlayers.Length; i++)
        {
            dataPlayers[i] = dataList[i].Split(';');
        }
    }
}


