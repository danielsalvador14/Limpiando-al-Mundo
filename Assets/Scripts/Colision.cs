using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    public Vector3 posicionAnterior;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Mapa")
        {
            print("Colision en independiente");
            transform.position = posicionAnterior;
        }

    }*/

    void OnCollisionEnter(Collision collision)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
            print("Colision en independiente");
        }

        // Play a sound if the colliding objects had a big impact.
        if (collision.relativeVelocity.magnitude > 2) { }
            //audioSource.Play();
    }
}
