using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ControlAudio : MonoBehaviour
{

    [SerializeField] public Slider controlVolumen;
    [SerializeField] public GameObject[] audios;
    // Start is called before the first frame update
    void Start()
    {
        audios=GameObject.FindGameObjectsWithTag("audio");
        controlVolumen.value= PlayerPrefs.GetFloat("volumneGrabado", 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject au in audios)
        {
            au.GetComponent<AudioSource>().volume=controlVolumen.value;
        }
    }

    public void guardarVolument()
    {
        PlayerPrefs.SetFloat("volumenGrabado",controlVolumen.value);
    }
}
