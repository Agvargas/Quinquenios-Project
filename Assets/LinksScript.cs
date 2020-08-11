using UnityEngine;

public class LinksScript : MonoBehaviour
{
    public GameObject panelLinks;
    public GameObject panelLinks2;
    public GameObject panelLinks3;
    public GameObject panelInfo;

    public void Update()
    {
        if (InteractuableScript.activeInteractuble != -1)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                panelLinks2.SetActive(true);
                panelInfo.SetActive(false);
            }
        }
        else
        {
            panelLinks.SetActive(false);
            panelLinks2.SetActive(false);
            panelLinks3.SetActive(false);
        }
    }

    public void WebsiteLink()
    {
        string url;
        switch (InteractuableScript.activeInteractuble)
        {
            case 0:
                url = "https://www.elevenproducciones.com/";
                break;
            case 1:
                url = "https://www.cobiscorp.com/";
                break;
            case 2:
                url = "https://www.asobancaria.com/";
                break;
            case 3:
                url = "https://www.avixa.org/es";
                break;
            case 4:
                url = "https://www.arkadium.com/free-online-games/";
                break;
            case 5:
                url = "https://www.3djuegos.com/";
                break;
            default:
                url = "https://www.cobiscorp.com/";
                break;
        }
        
        Application.OpenURL(url);
    }

    public void YoutubeLink()
    {
        string url;
        switch (InteractuableScript.activeInteractuble)
        {
            case 0:
                url = "https://www.youtube.com/watch?v=dmz_ehxfDjs";
                break;
            case 1:
                url = "https://www.youtube.com/watch?v=UrI68Jfrhck";
                break;
            case 2:
                url = "https://www.youtube.com/watch?v=spUd-1xGJXo";
                break;
            case 3:
                url = "https://www.youtube.com/watch?v=ajdOMbSaqcU";
                break;
            case 4:
                url = "https://www.youtube.com/watch?v=VNTgw-FotxU";
                break;
            case 5:
                url = "https://www.youtube.com/watch?v=gEFigDkfysQ&t=62s";
                break;
            default:
                url = "https://www.youtube.com/watch?v=duijRz9U8C0";
                break;
        }

        Application.OpenURL(url);
    }
}
