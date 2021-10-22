using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public bool esquerda;
    public bool direita;
    public bool cima;
    public Vector3 inicio;
    public float vel;

    void Start()
    {
        //inicio = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (esquerda)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector3(transform.position.x + 1, transform.position.y), Time.deltaTime * vel);
        }
        if (direita)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector3(transform.position.x - 1, transform.position.y), Time.deltaTime * vel);
        }
        if (cima)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 1), Time.deltaTime * vel);
        }

    }

    public void Centralizar()
    {
        transform.position = inicio;
    }
}
