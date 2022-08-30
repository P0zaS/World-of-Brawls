using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class MainMenu : MonoBehaviour
{
    public void CargarNivel(string nombreScena)
    {
        SceneManager.LoadScene(nombreScena);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
