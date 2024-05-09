using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cubo : MonoBehaviour
{
    public float velocidad;
    private string nombre = "Cubito";
    public Text mensajeText;

    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                nombre = value;
            }
            else
            {
                mensajeText.text = "El nombre no puede ser nulo ni una cadena vacía.";
            }
        }
    }

    void FixedUpdate()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float speed_x = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(speed_x * velocidad * Time.deltaTime, 0f, 0f);
        transform.position += movement;
    }
}
