using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tienda : MonoBehaviour
{
    private string nombre;
    private float precio;

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public Tienda(string nombre, float precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}
