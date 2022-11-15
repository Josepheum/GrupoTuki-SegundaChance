using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlPantalla : MonoBehaviour
{

    [SerializeField] public Slider controlBrillo;
    //[SerializeField] public GameObject[] audios;
    //[SerializeField] public Light brilloEscena;
    [SerializeField] public GameObject[] luces;

    // Start is called before the first frame update
    void Start()
    {
        luces=GameObject.FindGameObjectsWithTag("luz");
        controlBrillo.value= PlayerPrefs.GetFloat("brilloGuardado", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject luz in luces)
        {
           // luz.GetComponent<AudioSource>().volume=controlVolumen.value;
           luz.GetComponent<Light>().intensity=controlBrillo.value;
        }
        
           // brilloEscena.intensity=controlBrillo.value;
    }

    public void guardarBrillo()
    {
        PlayerPrefs.SetFloat("brilloGuardado",controlBrillo.value);
    }
}
