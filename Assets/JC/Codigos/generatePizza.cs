using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatePizza : MonoBehaviour
{
    [SerializeField]
    private GameObject Pizza;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;
    private int cantPizza = 0;
    [SerializeField]
    private int maxPizza;

    public GameObject point;

    // Start is called before the first frame update
    void Start()
    {
              
            InvokeRepeating("GenerateEnemy2", initTime, repeatTime);
        
    }

    void GenerateEnemy2()
    {
        if (cantPizza < maxPizza)
        {
            
            Instantiate(Pizza, new Vector3(-212.469f, 71.103f, -19.201f), transform.rotation);
            cantPizza++;
        }
    }
}