using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rectangulo : MonoBehaviour
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
            mensajeText.text = "¡Hola, " + cubo.Nombre + "!";
            anim.SetBool("AnimacionAgrandarse", true);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Cubo>() != null)
        {
            anim.SetBool("AnimacionAgrandarse", false);
            canvasManager.OcultarCartel();
        }
    }
}
