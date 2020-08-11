using UnityEngine;

public class TriggerInteratuable : MonoBehaviour
{
    public GameObject panelInfo;
    public int activeInteractuableNumber;
    //public GameObject youtubeVideoAudience;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //youtubeVideoAudience.SetActive(true);
            InteractuableScript.activeInteractuble = activeInteractuableNumber;
            panelInfo.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //youtubeVideoAudience.SetActive(false);
            InteractuableScript.activeInteractuble = -1;
            panelInfo.SetActive(false);
        }
    }
}
