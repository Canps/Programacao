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

    public void Submit()
    {
        Recordes.pontos[5] = pontos;
        if (Recordes.pontos[5] > Recordes.pontos[0])
        {
            Recordes.pontos[4] = Recordes.pontos[3];
            Recordes.pontos[3] = Recordes.pontos[2];
            Recordes.pontos[2] = Recordes.pontos[1];
            Recordes.pontos[1] = Recordes.pontos[0];
            Recordes.pontos[0] = Recordes.pontos[5];
        }
        else if (Recordes.pontos[5] > Recordes.pontos[1])
        {
            Recordes.pontos[4] = Recordes.pontos[3];
            Recordes.pontos[3] = Recordes.pontos[2];
            Recordes.pontos[2] = Recordes.pontos[1];
            Recordes.pontos[1] = Recordes.pontos[5];
        }
        else if (Recordes.pontos[5] > Recordes.pontos[2])
        {
            Recordes.pontos[4] = Recordes.pontos[3];
            Recordes.pontos[3] = Recordes.pontos[2];
            Recordes.pontos[2] = Recordes.pontos[5];
        }
        else if (Recordes.pontos[5] > Recordes.pontos[3])
        {
            Recordes.pontos[4] = Recordes.pontos[3];
            Recordes.pontos[3] = Recordes.pontos[5];
        }
        else if (Recordes.pontos[5] > Recordes.pontos[4])
        {
            Recordes.pontos[4] = Recordes.pontos[5];
        }
    }
}
