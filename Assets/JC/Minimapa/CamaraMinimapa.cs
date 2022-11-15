using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraMinimapa : MonoBehaviour
{
    // Start is called before the first frame update
   [SerializeField] private Transform jugador;

   private void LateUpdate()
   {
        Vector3 newPosition=jugador.position;
        newPosition.y=transform.position.y;
        transform.position=newPosition;
   }
}
