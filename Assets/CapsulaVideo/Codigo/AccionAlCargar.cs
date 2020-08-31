using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AccionAlCargar : MonoBehaviour
{

    public UnityEvent OnCargar;


    private void OnEnable()
    {
        ActivarAccion();
    }

    public void ActivarAccion()
    {
        OnCargar.Invoke();
    }
}
