﻿using UnityEngine;
using UnityEngine.UI;

public class CapturaCamara : MonoBehaviour
{

    public WebCamTexture backCam;
    public RawImage preImage;
    //public bool preImage=false;

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

    private void OnDisable()
    {
        backCam.Stop();
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("activo camara");
            ActivarCamara();
        }
    }

    void ActivarCamara()
    {
        backCam = new WebCamTexture();

        //if (preImage)
            preImage.material.mainTexture = backCam;
        //
            GetComponent<Renderer>().material.mainTexture = backCam;

        backCam.Play();
    }

    public void PararCamara()
    {
        backCam.Stop();
        //Debug.Log("Paro camara");
    }

    public void ComenzarCamara()
    {
        backCam.Play();
    }

}
