using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CapturaCamara : MonoBehaviour
{

    public WebCamTexture backCam;

   // public Image img;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void OnEnable()
    {

        ActivarCamara();

        /*if (!backCam.isPlaying)
        {
            backCam.Play();
        }*/
    }

    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("activo camara");
            ActivarCamara();
        }
    }

    void ActivarCamara()
    {
        backCam = new WebCamTexture();
        
        GetComponent<Renderer>().material.mainTexture = backCam;

        backCam.Play();
    }

    public void PararCamara()
    {
        backCam.Stop();
        Debug.Log("Paro camara");
    }

    public void ComenzarCamara()
    {
        backCam.Play();
    }

}
