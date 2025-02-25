using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    [SerializeField] private float velocidad;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(0, 0, Movimiento().z);
    }
    Vector3 Movimiento()
    {
        return transform.forward * velocidad;
    }
}


    
