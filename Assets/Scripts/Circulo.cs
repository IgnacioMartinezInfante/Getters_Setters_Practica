using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Circulo : MonoBehaviour
{
    private Animator anim;

    public CanvasManager canvasManager;
    public Text mensajeText;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>() != null)
        {
            Cubo cubo = collision.gameObject.GetComponent<Cubo>();
            if (cubo.Nombre == "Cubito")
            {
                cubo.Nombre = "Circulo";
                mensajeText.text = "¡Hola, ahora sos un " + cubo.Nombre + "!";
                anim.SetBool("AnimacionSaludo", true);
            }
            else
            {
                mensajeText.text = "¡Hola! ya sos un " + cubo.Nombre + " diferente.";
                anim.SetBool("AnimacionSaludo", true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>() != null)
        {
            anim.SetBool("Animacionsaludo", false);
            canvasManager.OcultarCartel();
        }
    }
}
