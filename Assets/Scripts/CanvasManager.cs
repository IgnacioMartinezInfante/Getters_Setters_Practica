using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    public Text mensajeText;
    public void OcultarCartel()
    {
        mensajeText.text = "";
    }
}
