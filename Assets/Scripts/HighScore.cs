using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.pontos <= Recordes.pontos[0])
        {
            GetComponent<Text>().text = Recordes.pontos[0].ToString();
        }
        else if(Global.pontos > Recordes.pontos[0])
        {
            GetComponent<Text>().text = Global.pontos.ToString();
        }
        
    }
}
