using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PantallaGano : MonoBehaviour

{
    [SerializeField] static bool JuegoPausado=true;
    [SerializeField] private GameObject menuPausa;

    // Start is called before the first frame update
    void Start()
    {
       JuegoPausado=true;
       Cursor.visible=true;
    }

   
    void Update()
    {
   //     if (Input.GetKeyDown(KeyCode.J))
   //     {
    //        if (JuegoPausado)
    //        {
    //            Continuar();
   //         } else
   //         {
                Pausar();
    //        }
    //    }

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
