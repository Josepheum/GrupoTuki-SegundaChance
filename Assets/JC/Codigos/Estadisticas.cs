using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Estadisticas : MonoBehaviour
{
    public static int intentos;
    [SerializeField] private string puntajeTexto="Puntaje:";
    [SerializeField] private TextMeshProUGUI textoDePuntaje;

    public static Estadisticas estadisticas;

    void Awake()
    {
        estadisticas=this;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(estadisticas !=null)
        {
            textoDePuntaje.text= puntajeTexto + intentos.ToString();
        }
    }
}
