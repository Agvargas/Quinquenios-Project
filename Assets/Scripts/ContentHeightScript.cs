using UnityEngine;
using UnityEngine.UI;

public class ContentHeightScript : MonoBehaviour
{
    public GameObject imagePrefab;

    public float height;
    private float childs;
    
    public GameController data;


    public string year;

    private void Awake()
    {
        for (int i = 0; i < 1309; i++)
        {
            if (data.dataPlayers[i][4] == year)
            {
                GameObject photo= Instantiate(imagePrefab, transform);
                photo.name = data.dataPlayers[i][0];
                photo.GetComponent<Image>().sprite = Resources.Load<Sprite>("Sprites/" + year + "/" + data.dataPlayers[i][0]);
            }
        }
    }

    void Start()
    {
        childs = GetComponent<Transform>().childCount;

        childs /= 6;

        height *= Mathf.CeilToInt(childs);
        height += 10;

        GetComponent<RectTransform>().sizeDelta = new Vector2(0, height);
    }

    public void Year(string a)
    {
        year = a;
    }
}