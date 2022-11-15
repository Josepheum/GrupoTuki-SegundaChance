using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlEscena : MonoBehaviour
{
    [SerializeField] static bool JuegoPausado=false;
    [SerializeField] private GameObject menuPausa;

    // Start is called before the first frame update
    void Start()
    {
        JuegoPausado=false;
        Cursor.visible=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            if (JuegoPausado)
            {
                Continuar();
            } else
            {
                Pausar();
            }
        }
    }

    public void Continuar()
    {
        
        menuPausa.SetActive(false);
        Time.timeScale=1f;
        JuegoPausado=false;
        Cursor.visible=false;
        Cursor.lockState=CursorLockMode.Locked;
    }
    public void Pausar()
    {
        Cursor.visible=true;
        Cursor.lockState=CursorLockMode.None;
        menuPausa.SetActive(true);
        Time.timeScale=0f;
        JuegoPausado=true;

    }

    public void CargarMenu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(0);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }
}
