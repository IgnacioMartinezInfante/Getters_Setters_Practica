using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        Tienda espadaDeHierro = new Tienda("Espada de Hierro", 1.5f);
        Tienda escudoDeMadera = new Tienda("Escudo de Madera", 0.5f);
        Tienda pistolaPewPew = new Tienda("Pistola:Pew-Pew", 9999f);

        Debug.Log(espadaDeHierro.Nombre + ": " + espadaDeHierro.Precio.ToString("C2"));
        Debug.Log(escudoDeMadera.Nombre + ": " + escudoDeMadera.Precio.ToString("C2"));
        Debug.Log(pistolaPewPew.Nombre + ": " + pistolaPewPew.Precio.ToString("C2"));
    }
}
