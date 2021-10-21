using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool moveu;
    static bool setas;
    public GameObject[] grade = new GameObject[9];
    int index = 4;
    public GameObject perdeu;

    void Start()
    {
        transform.position = grade[4].transform.position;
    }


    void Update()
    {
        if (!Global.setas && !Global.pausado)
        {
            if (Input.touchCount > 0)
            {
                Touch t = Input.GetTouch(0);

                if (t.phase == TouchPhase.Moved)
                {
                    if (!moveu && t.deltaPosition.x > 80)
                    {
                        Direita();
                    }
                    else if (!moveu && t.deltaPosition.x < -80)
                    {
                        Esquerda();
                    }

                    if (!moveu && t.deltaPosition.y > 80)
                    {
                        Cima();
                    }
                    else if (!moveu && t.deltaPosition.y < -80)
                    {
                        Baixo();
                    }


                }

                if (t.phase == TouchPhase.Ended)
                {
                    moveu = false;
                }
            }
        }
    }

    public void Cima()
    {
        moveu = true;
        //transform.position += Vector3.up;
        if(index > 2)
        {
            index -= 3;
            transform.position = grade[index].transform.position;
        }
        
    }

    public void Baixo()
    {
        moveu = true;
        //transform.position += Vector3.down;
        if (index < 6)
        {
            index += 3;
            transform.position = grade[index].transform.position;
        }
    }

    public void Esquerda()
    {
        moveu = true;
        //transform.position += Vector3.left;
        if (index != 0 && index != 3 && index != 6)
        {
            index --;
            transform.position = grade[index].transform.position;
        }
    }

    public void Direita()
    {
        moveu = true;
        //transform.position += Vector3.right;
        if (index != 2 && index != 5 && index != 8)
        {
            index ++;
            transform.position = grade[index].transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Inimigo"))
        {
            Global.pausado = true;
            perdeu.SetActive(true);

        }
    }
}

