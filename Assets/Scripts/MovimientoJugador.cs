using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 3f;
    public Vector3 posicionAnterior;

    public int BasuraTotal = 10;
    int BasuraTomada = 0;

    public float Tiempo = 0.0f;
    public Text Contador;

    public Text Puntaje;
    int Puntos = 0;

    public Text Restantes;

    public GameObject PausaMenu;
    public bool Pausado = false;

    public GameObject FinalMenu;

    public AudioSource audio;

    void Start()
    {
        Contador.text = "0000";
        Puntaje.text = Puntos.ToString();
        Restantes.text = BasuraTomada + "/" + BasuraTotal;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            print("Colision nn");
            transform.position = posicionAnterior;
        }
    }
    void ActualizarTiempo()
    {
        if (Pausado) { return; }
        Tiempo += Time.deltaTime;
        Contador.text = Tiempo.ToString("f0");

        Restantes.text = BasuraTomada + "/" + BasuraTotal;
        Puntaje.text = Puntos.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        posicionAnterior = transform.position;
        ActualizarTiempo();

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Pausado) { return;  }
            //print("Fecha Arriba key was pressed");
            Vector3 var = transform.position + Camera.main.transform.forward * velocidad * Time.deltaTime;
            transform.position = new Vector3(var.x, transform.position.y, var.z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Pausado) { return; }
            //print("Fecha Abajo key was pressed");
            Vector3 var = transform.position + Camera.main.transform.forward * velocidad * Time.deltaTime * -1;
            transform.position = new Vector3(var.x, transform.position.y, var.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (Pausado) { return; }
            //print("Fecha Derecha key was pressed");
            Vector3 var = transform.position + Camera.main.transform.right * velocidad * Time.deltaTime;
            transform.position = new Vector3(var.x, transform.position.y, var.z);
            //transform.position = new Vector3(transform.position.x, transform.position.y, var.z);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (Pausado) { return; }
            //print("Fecha Izquierda key was pressed");
            Vector3 var = transform.position + Camera.main.transform.right * velocidad * Time.deltaTime * -1;
            //transform.position = new Vector3(transform.position.x, transform.position.y, var.z);
            transform.position = new Vector3(var.x, transform.position.y, var.z);
        }
        
        
        else if (Input.GetMouseButtonDown(0))
        {
            print("Click Normal was pressed");
        }
        else if (Input.GetMouseButtonDown(1))
        {
            print("Click Izquierdo was pressed");
            if (Pausado)
            {
                PausaMenu.SetActive(false);
                Pausado = false;
                audio.volume = 0.7f;
            }
            else
            {
                PausaMenu.SetActive(true);
                Pausado = true;
                audio.volume = 0.2f;
            }
        }
    }

    public void RecogiendoBasura()
    {
        BasuraTomada++;
        Puntos = Puntos + 100;
        if(BasuraTomada == BasuraTotal) { PantallaFinal(); }
    }

    void PantallaFinal()
    {
        FinalMenu.SetActive(true);
        Pausado = true;
        Restantes.text = BasuraTomada + "/" + BasuraTotal;
        Puntaje.text = Puntos.ToString();
    }
}
