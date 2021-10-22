using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PontFinal : MonoBehaviour
{
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Global.pontos > Recordes.pontos[0])
        {
            texto.GetComponent<Text>().text = "Novo recorde";
            GetComponent<Text>().text = "";
        }
        else
        {
            texto.GetComponent<Text>().text = "Pontuação";
            GetComponent<Text>().text = Global.pontos.ToString();
        }

    }
}
