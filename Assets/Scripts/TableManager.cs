using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TableManager : MonoBehaviour
{
    public TMPro.TMP_Text titleText;
    public TMPro.TMP_Text columnHeadersText;
    public TMPro.TMP_Text dataCellsText;
    public GameObject panelRows;
    public GameObject panelHeaders;
    public GameObject panelData;

    DataManager data;
    string title;
    int columnsCount;
    int dataCount;

    void Start()
    {
        data = GetComponent<DataManager>();

        UpdateTitle();

        UpdateColumnHeader();

        UpdateData();
    }

    public void UpdateTable()
    {
        SceneManager.LoadScene(0);
    }

    public void UpdateTitle()
    {
        title = data.items["Title"].ToString();

        titleText.text = title;
    }

    public void UpdateColumnHeader()
    {
        columnsCount = data.items["ColumnHeaders"].Count;

        for (int i = 0; i < columnsCount; i++)
        {
            TMPro.TMP_Text columnHeader = GameObject.Instantiate(columnHeadersText, panelHeaders.transform);
            columnHeader.text = data.items["ColumnHeaders"][i].ToString();
        }
    }

    public void UpdateData()
    {
        dataCount = data.items["Data"].Count;

        for (int i = 0; i < dataCount; i++)
        {
            GameObject panelDataIntance = GameObject.Instantiate(panelRows, panelData.transform);

            for (int j = 0; j < columnsCount; j++)
            {
                TMPro.TMP_Text dataCell = GameObject.Instantiate(dataCellsText, panelDataIntance.transform);
                
                //if the key is not found just intantiate a blank cell for that column
                try
                {
                    dataCell.text = data.items["Data"][i][data.items["ColumnHeaders"][j].ToString()].ToString();
                }
                catch (KeyNotFoundException e)
                {
                    Debug.LogException(e);
                }
            }
        }
    }
}
