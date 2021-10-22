using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setas : MonoBehaviour
{
    public GameObject setas;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        setas.SetActive(Global.setas);
    }
}
