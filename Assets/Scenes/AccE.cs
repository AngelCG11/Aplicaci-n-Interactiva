using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccE : MonoBehaviour
{
    Animator Explota_Animator;
    GameObject Explota;
    GameObject[] Explosiones;

    void Awake()
    {
        Explosiones = GameObject.FindGameObjectsWithTag("Explosiones");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        foreach (GameObject Explota in Explosiones)
        {
            Explota_Animator = Explota.GetComponent<Animator>();
            Explota_Animator.SetBool("Explotando", true);
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        foreach (GameObject Explota in Explosiones)
        {
            Explota_Animator = Explota.GetComponent<Animator>();
            Explota_Animator.SetBool("Explotando", false);
        }
    }
}



