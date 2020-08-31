using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizarBarraContador : MonoBehaviour
{
    Image miImage;
    public Sprite[] fotograma;
    public ContadorTiempo infoContadorTiempo;

    private void Awake()
    {
        miImage = GetComponent<Image>();
    }

    void Update()
    {
        miImage.sprite = fotograma[infoContadorTiempo.segundo];
    }
}
