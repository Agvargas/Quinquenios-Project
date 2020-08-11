using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSignIn : MonoBehaviour
{
    public GameObject panelSignIn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            panelSignIn.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            panelSignIn.SetActive(false);
        }
    }
}
