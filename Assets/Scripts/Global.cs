using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour
{
    public static bool setas = true;
    public static bool pausado;
    public static int pontos;
    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        
    }

    public void Trocar()
    {
        setas = !setas;
    }

    public void Pausar()
    {
        pausado = !pausado;
    }
}
