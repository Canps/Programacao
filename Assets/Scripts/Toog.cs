using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toog : MonoBehaviour
{
    public Sprite esquerda;
    public Sprite direita;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.setas)
        {
            GetComponent<Image>().sprite = direita;
        }
        else
        {
            GetComponent<Image>().sprite = esquerda;
        }
    }
}
