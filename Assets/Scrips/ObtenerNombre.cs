using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObtenerNombre : MonoBehaviour
{
    public Text nombre;
    void Start()
    {
        nombre.text = PlayerPrefs.GetString("Nombre"); 
    }

   
}
