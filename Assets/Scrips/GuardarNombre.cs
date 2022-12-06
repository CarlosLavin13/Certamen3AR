using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarNombre : MonoBehaviour
{
    
    public  TMPro.TMP_InputField input;
    public void setNombre()
    {
        string n = input.text;

        if (string.IsNullOrEmpty(n))
        {
            Debug.Log("Valor Nulo");
        }
        else
        {
            Debug.Log("El Nombre es:" +n);
            PlayerPrefs.SetString("Nombre", n);
            SceneManager.LoadScene(0);

        }
    
    }
}
