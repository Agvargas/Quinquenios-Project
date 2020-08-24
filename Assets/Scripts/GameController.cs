using UnityEngine;
using System.IO;
using System.Text;

public class GameController : MonoBehaviour
{
    public string[][] dataPlayers = new string[1309][];
    private string[] dataList = new string[1309];

    void Start()
    {
        dataList = File.ReadAllLines(Application.streamingAssetsPath + "/BDCondecorados.txt", Encoding.UTF7);
        
        for (int i = 0; i < dataPlayers.Length; i++)
        {
            dataPlayers[i] = dataList[i].Split(';');
        }
    }
}


