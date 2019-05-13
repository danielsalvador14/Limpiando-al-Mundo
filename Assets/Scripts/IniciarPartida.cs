using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IniciarPartida : MonoBehaviour
{
    public void CargarPartida( int nivel )
    {
        if(nivel == 1)
        {
            SceneManager.LoadScene("Nivel 1");
        }
        
    }

    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene("Titulos del Inicio");
    }
}
