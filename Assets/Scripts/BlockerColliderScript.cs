using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerColliderScript : MonoBehaviour
{
    public GameObject popUp;

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        popUp.SetActive(true);
    //    }
    //}

    private void OnCollisionEnter(Collision collision)
    {

            popUp.SetActive(true);

    }
}
