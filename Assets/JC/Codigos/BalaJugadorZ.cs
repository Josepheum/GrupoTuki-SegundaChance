using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaJugadorZ : MonoBehaviour
{
    public int cantidad = 10;
    //public GameObject Enemigo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemigo2")
        {
            other.GetComponent<VidaEnemigoZ>().RestarVidaEnemigo(cantidad);
            Destroy(gameObject); 
        }
        
    }
    private void Update()
    {
        
    }

    

}
