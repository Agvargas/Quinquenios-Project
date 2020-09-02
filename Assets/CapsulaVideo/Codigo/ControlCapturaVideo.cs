//using RenderHeads.Media.AVProMovieCapture;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCapturaVideo : MonoBehaviour
{

    //public CaptureFromScreen infoCaptura;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            
            Debug.Log("Termino de grabar");
        }
    }

    public void ComenzarAGrabar()
    {
        //infoCaptura.Start();
        Debug.Log("Empezo a grabar");
        //infoCaptura.StartCapture();
    }

    public void PararDeGrabar()
    {
        //infoCaptura.StopCapture();
        Debug.Log("Termino de grabar");
    }
}
