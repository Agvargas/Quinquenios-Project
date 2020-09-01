using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ContadorTiempo : MonoBehaviour
{
    public float duracion;
    float contador;
    [HideInInspector]
    public int segundo;

    public UnityEvent OnTerminar;

    private void OnEnable()
    {
        contador = duracion; 
    }

    void Update()
    {
        if (contador <= 0)
        {
            OnTerminar.Invoke();
            contador = duracion;
        }
        else
        {
            contador -= Time.deltaTime;
            segundo = (int)contador;
        }    
    }
}
