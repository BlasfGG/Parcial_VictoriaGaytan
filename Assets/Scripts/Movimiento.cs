using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    [SerializeField]
    float velocidad = 0f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        MovimientoJugador();
    }
    void MovimientoJugador() // Se establece el movimiento solo en el eje X.
    {
        rb.velocity = new Vector3(Horizontal(), 0, 0) * velocidad;
    }
    public float Horizontal() // Accede al comando preestablecido en horizontal.
    {
        return Input.GetAxis("Horizontal");
    }
}
    

