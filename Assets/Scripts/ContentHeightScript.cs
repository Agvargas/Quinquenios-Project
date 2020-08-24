using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ContentHeightScript : MonoBehaviour
{
    public GameObject imagePrefab;
    public GameController data;
    public TMP_InputField searchText;

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
                    switch (data.dataPlayers[i][4])
                    {
                        case "30":
                            photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/30/" + data.dataPlayers[i][0]);
                            break;
                        case "35":
                            photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/35/" + data.dataPlayers[i][0]);
                            break;
                        case "40":
                            photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/40/" + data.dataPlayers[i][0]);
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (data.dataPlayers[i][4] == year)
            {
                GameObject photo= Instantiate(imagePrefab, transform);
                photo.name = data.dataPlayers[i][0];
                photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + year + "/" + data.dataPlayers[i][0]);
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
        for (int i = 0; i < childs; i++)
        {
            if (!GetComponent<Transform>().GetChild(i).gameObject.name.Contains(searchText.text))
            {
                GetComponent<Transform>().GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}