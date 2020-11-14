using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
    public Stickman Jugador;

    private void Update() 
    {
        if (GameObject.Find("Player") != null)
        {
            if(Jugador.GameOver == true)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    public void Change_scene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Salir()
    {
        Debug.Log("Salir");
        Application.Quit();
    }
}
