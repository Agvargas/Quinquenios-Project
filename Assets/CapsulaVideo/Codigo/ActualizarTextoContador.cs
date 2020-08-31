using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ActualizarTextoContador : MonoBehaviour
{
    ContadorTiempo infoContadorTiempo;
    TextMeshProUGUI labelTiempo;

    private void Awake()
    {
        labelTiempo = GetComponent<TextMeshProUGUI>();
        infoContadorTiempo = GetComponent<ContadorTiempo>();
    }
    
    void Update()
    {
        labelTiempo.text = infoContadorTiempo.segundo.ToString();
    }
}
