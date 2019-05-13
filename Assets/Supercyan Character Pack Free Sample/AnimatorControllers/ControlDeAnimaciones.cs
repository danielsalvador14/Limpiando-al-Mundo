using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeAnimaciones : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("Caminando", true);
            anim.SetBool("Reversa", false);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("Reversa", true);
            anim.SetBool("Caminando", false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Caminando", true);
            anim.SetBool("Reversa", false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("Caminando", true);
            anim.SetBool("Reversa", false);
        }
        else
        {
            anim.SetBool("Caminando", false);
            anim.SetBool("Reversa", false);
        }
    }
}
