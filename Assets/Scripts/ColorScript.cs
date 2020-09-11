using UnityEngine;
using UnityEngine.UI;

public class ColorScript : MonoBehaviour
{
    private bool b;

    void Start()
    {
        b = false;
        InvokeRepeating("ChangeColor",1f,1f);
    }

    private void ChangeColor()
    {
        if (b)
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            b = false;
        }
        else
        {
            GetComponent<Image>().color = new Color32(255, 255, 255, 125);
            b = true;
        }
    }
}
