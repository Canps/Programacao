using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    float pontuar = 0;
    int pontos = 0;
    void Start()
    {
        GetComponent<Text>().text = pontos.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        pontuar += Time.deltaTime;
        pontos = (int)pontuar;
        GetComponent<Text>().text = pontos.ToString();
        Global.pontos = pontos;
    }
}
