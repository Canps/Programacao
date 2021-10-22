using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cenas : MonoBehaviour
{
    public void Update()
    {
        if (Global.pausado)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Global.pausado = false;
    }
    public void Instrucoes()
    {
        SceneManager.LoadScene("Instrucoes", LoadSceneMode.Single);
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos", LoadSceneMode.Single);
    }
    public void Jogo()
    {
        SceneManager.LoadScene("Jogo", LoadSceneMode.Single);
    }
    public void Recordes()
    {
        SceneManager.LoadScene("Records", LoadSceneMode.Single);
    }


}
