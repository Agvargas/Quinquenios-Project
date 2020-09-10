using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ContentHeightScript : MonoBehaviour
{
    public GameObject imagePrefab;
    public GameController data;
    public TMP_InputField searchText;
    public Image mainImage;

    public float height;
    private float childs;
    
    public string year;

    private void Awake()
    {
        for (int i = 0; i < 1309; i++)
        {
            if (year == "30")
            {
                if (data.dataPlayers[i][4] == "30" || data.dataPlayers[i][4] == "35" || data.dataPlayers[i][4] == "40")
                {
                    GameObject photo = Instantiate(imagePrefab, transform);
                    photo.name = data.dataPlayers[i][0];
                    photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + year + "/" + data.dataPlayers[i][0]);
                    photo.GetComponent<ImageScript>().contentScript = GetComponent<ContentHeightScript>();
                    photo.GetComponent<ImageScript>().personID = data.dataPlayers[i][5];
                }
            }
            else if (data.dataPlayers[i][4] == year)
            {
                GameObject photo= Instantiate(imagePrefab, transform);
                photo.name = data.dataPlayers[i][0];
                photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + year + "/" + data.dataPlayers[i][0]);
                photo.GetComponent<ImageScript>().contentScript = GetComponent<ContentHeightScript>();
                photo.GetComponent<ImageScript>().personID = data.dataPlayers[i][5];
            }
        }
    }

    void Start()
    {
        float rows;
        childs = GetComponent<Transform>().childCount;
        rows = childs / 6;

        height *= Mathf.CeilToInt(rows);
        height += 10;

        GetComponent<RectTransform>().sizeDelta = new Vector2(0, height);
    }

    public void Refresh()
    {
        for (int i = 0; i < childs; i++)
        {
            GetComponent<Transform>().GetChild(i).gameObject.SetActive(true);
        }
    }

    public void Search()
    {
        Refresh();
        for (int i = 0; i < childs; i++)
        {
            if (!GetComponent<Transform>().GetChild(i).gameObject.name.Contains(searchText.text))
            {
                GetComponent<Transform>().GetChild(i).gameObject.SetActive(false);
            }
        }
    }

    public void UpdateImage(string nameImage, string person)
    {
        mainImage.sprite= Resources.Load<Sprite>("Sprites/" + year + "/" + nameImage);
        data.personID = person;
        data.ActiveMessenger();
    }
}