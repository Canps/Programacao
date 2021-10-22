using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    int rand;
    public GameObject[] avisos = new GameObject[9];
    public GameObject[] tiros = new GameObject[9];
    float tempo = 0;
    float intervalo = 5;
    int[] aviso = new int[4];
    int index = 0;

    private void Start()
    {
        foreach (GameObject a in tiros)
        {
            a.SetActive(true);
            a.GetComponent<Projetil>().Centralizar();
            a.SetActive(false);
        }
    }
    private void Update()
    {
        if (tempo > 0)
        {
            tempo -= Time.deltaTime;
        }
        else
        {
            tempo = 0;
            index = 0;
            foreach (GameObject a in avisos)
            {
                a.SetActive(false);
            }
        }

        if (intervalo > 0)
        {
            intervalo -= Time.deltaTime;
        }
        else
        {

            foreach (GameObject a in tiros)
            {
                a.GetComponent<Projetil>().Centralizar();
                a.SetActive(false);
            }
            intervalo = 0;
            if (Global.pontos < 30)
            {
                Invocar();
            }
            else if (Global.pontos < 60)
            {
                Invocar();
                Invocar();
            }
            else if (Global.pontos < 100)
            {
                Invocar();
                Invocar();
                Invocar();
            }
            else
            {
                Invocar();
                Invocar();
                Invocar();
                Invocar();
            }

        }

    }

    void Invocar()
    {
        rand = Random.Range(1, 10);
        aviso[index] = rand;
        Verificar();
        rand = aviso[index];

        index++;
        tempo = 1;
        intervalo = 2;
        switch (rand)
        {
            case 1:
                InfEsq();
                break;
            case 2:
                CenEsq();
                break;
            case 3:
                SupEsq();
                break;
            case 4:
                EsqCima();
                break;
            case 5:
                CenCima();
                break;
            case 6:
                DirCima();
                break;
            case 7:
                SupDir();
                break;
            case 8:
                CenDir();
                break;
            case 9:
                InfDir();
                break;
        }
    }

    void InfEsq()
    {
        tiros[0].SetActive(true);
        avisos[0].SetActive(true);
    }
    void CenEsq()
    {
        tiros[1].SetActive(true);
        avisos[1].SetActive(true);
    }
    void SupEsq()
    {
        tiros[2].SetActive(true);
        avisos[2].SetActive(true);
    }
    void EsqCima()
    {
        tiros[3].SetActive(true);
        avisos[3].SetActive(true);
    }
    void CenCima()
    {
        tiros[4].SetActive(true);
        avisos[4].SetActive(true);
    }
    void DirCima()
    {
        tiros[5].SetActive(true);
        avisos[5].SetActive(true);
    }
    void SupDir()
    {
        tiros[6].SetActive(true);
        avisos[6].SetActive(true);
    }
    void CenDir()
    {
        tiros[7].SetActive(true);
        avisos[7].SetActive(true);
    }
    void InfDir()
    {
        tiros[8].SetActive(true);
        avisos[8].SetActive(true);
    }

    void Verificar()
    {
        if (index == 1)
        {
            if (aviso[1] == aviso[0])
            {
                if (aviso[1] != 9)
                    aviso[1]++;
                else
                    aviso[1] = 1;
            }
        }
        else if (index == 2)
        {
            if (aviso[2] == aviso[0] || aviso[2] == aviso[1])
            {
                if (aviso[2] != 9)
                    aviso[2]++;
                else
                    aviso[2] = 1;
                Verificar();
            }

            if (aviso[0] + aviso[1] + aviso[2] == 6 || aviso[0] + aviso[1] + aviso[2] == 24)
            {
                if (aviso[2] != 9)
                    aviso[2]++;
                else
                    aviso[2] = 1;
                Verificar();
            }

            if (aviso[0] > 3 && aviso[0] < 7 && aviso[1] > 3 && aviso[1] < 7 && aviso[2] > 3 && aviso[2] < 7)
            {
                if (aviso[2] != 9)
                    aviso[2]++;
                else
                    aviso[2] = 1;
                Verificar();
            }
        }
        else if (index == 3)
        {
            if (aviso[3] == aviso[0] || aviso[3] == aviso[1] || aviso[3] == aviso[2])
            {
                if (aviso[3] != 9)
                    aviso[3]++;
                else
                    aviso[3] = 1;
                Verificar();
            }

            if (aviso[3] < 4)
            {
                if ((aviso[0] < 4 && aviso[1] < 4) || (aviso[2] < 4 && aviso[1] < 4) || (aviso[0] < 4 && aviso[2] < 4))
                {
                    if (aviso[3] != 9)
                        aviso[3]++;
                    else
                        aviso[3] = 1;
                    Verificar();
                }
            }
            else if (aviso[3] > 6)
            {
                if ((aviso[0] > 6 && aviso[1] > 6) || (aviso[2] > 6 && aviso[1] > 6) || (aviso[0] > 6 && aviso[2] > 6))
                {
                    if (aviso[3] != 9)
                        aviso[3]++;
                    else
                        aviso[3] = 1;
                    Verificar();
                }
            }
            else if (aviso[3] < 7 && aviso[3] > 3)
            {
                if (((aviso[0] < 7 && aviso[0] > 3) && (aviso[1] < 7 && aviso[1] > 3)) || ((aviso[0] < 7 && aviso[0] > 3) && (aviso[2] < 7 && aviso[2] > 3)) || ((aviso[1] < 7 && aviso[1] > 3) && (aviso[2] < 7 && aviso[2] > 3)))
                {
                    if (aviso[3] != 9)
                        aviso[3]++;
                    else
                        aviso[3] = 1;
                    Verificar();
                }
            }
        }
    }
}
