using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceTrigger : MonoBehaviour
{
    public GameObject youtubeVideoAudience;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
            youtubeVideoAudience.SetActive(true);

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            youtubeVideoAudience.SetActive(false);
    }
}
