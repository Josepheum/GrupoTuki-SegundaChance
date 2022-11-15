using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLvl1 : MonoBehaviour
{
    public Transform enemigo;
    public Transform[] puntosDeControl;
    private float velocidad = 0.5f;
    private bool activeCollider;
    private bool enemigoPatrullando;

    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine("RealizarPatrullaje");
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator RealizarPatrullaje()
    {

        int i = 0;
        Vector3 nuevaPosicion = new Vector3(puntosDeControl[i].position.x, enemigo.transform.position.y, puntosDeControl[i].position.z);
        while (true)
        {
            while (enemigo.transform.position != nuevaPosicion)
            {
                enemigo.transform.position = Vector3.MoveTowards(enemigo.transform.position, nuevaPosicion, velocidad * Time.deltaTime);
                enemigo.transform.LookAt(nuevaPosicion);

                yield return null;

            }
            if (i < puntosDeControl.Length - 1)
            {
                i++;
            }
            else
            {
                i = 0;
            }
            nuevaPosicion = new Vector3(puntosDeControl[i].position.x, enemigo.transform.position.y, puntosDeControl[i].position.z);
            Debug.Log(i);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            StopCoroutine("RealizarPatrullaje");
            GetComponent<NavMeshManager>().enabled = true;
            GetComponent<NavMeshAgent>().enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<NavMeshManager>().enabled = false;
            GetComponent<NavMeshAgent>().enabled = false;
            StartCoroutine("RealizarPatrullaje");
        }
    }
}
