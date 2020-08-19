using UnityEngine;

public class ContentHeightScript : MonoBehaviour
{
    public float height;
    private float childs;

    void Start()
    {
        childs = GetComponent<Transform>().childCount;

        childs /= 6;

        height *= Mathf.CeilToInt(childs);
        height += 10;

        GetComponent<RectTransform>().sizeDelta = new Vector2(0, height);
    }
}
