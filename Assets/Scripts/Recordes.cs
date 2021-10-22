using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recordes : MonoBehaviour
{
    public GameObject[] ranks = new GameObject[5];
    public static int[] pontos = new int[6];

    void Start()
    {

    }


    void Update()
    {
        for (int i = 0; i < ranks.Length; i++)
        {
            ranks[i].GetComponent<Text>().text = pontos[i].ToString();
            if (ranks[i].GetComponent<Text>().text == "0")
            {
                ranks[i].GetComponent<Text>().text = "";
            }
        }
    }


}
