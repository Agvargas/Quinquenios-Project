using UnityEngine;
using UnityEngine.UI;

public class TriggerSignIn : MonoBehaviour
{
    public GameObject popUp;
    public Button worldButton;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            popUp.SetActive(true);
            worldButton.interactable = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            popUp.SetActive(false);
            worldButton.interactable = false;
        }
    }
}
