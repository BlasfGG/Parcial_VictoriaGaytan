using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    [SerializeField] private GameObject enemigoPrefab;
    [SerializeField] private float velEnemigo;
    [SerializeField] private float tiempoEspera;

    [SerializeField] private float negativoX;
    [SerializeField] private float positivoX;
    [SerializeField] private float posicionY;
    [SerializeField] private float posicionZ;

    bool Activo = true;

    void Update()
    {
        Respawnear();
    }
    void Respawnear()
    {
        if (Activo)
        {
            float posicionX = Random.Range(negativoX, positivoX);

            Vector3 posicionSpawn = new Vector3(posicionX, posicionY, posicionZ);

            // Quaternion rotacionQuaternion = Quaternion.Euler(-84, 4, 85);
            
            GameObject clone = Instantiate(enemigoPrefab, posicionSpawn, transform.rotation);
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddForce(Vector3.forward * 10f);
            Destroy(clone, 20);
            StartCoroutine(TiempoEspera());
        }
    }

    IEnumerator TiempoEspera() 
    {
        Activo = false;
        yield return new WaitForSeconds(tiempoEspera);
        Activo = true;
    }


}


   

