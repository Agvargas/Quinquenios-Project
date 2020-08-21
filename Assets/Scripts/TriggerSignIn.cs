using UnityEngine;

public class TriggerSignIn : MonoBehaviour
{
    public GameObject popUp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            popUp.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            popUp.SetActive(false);
        }
    }
}
