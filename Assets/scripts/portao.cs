﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portao : MonoBehaviour
{

    // Responsável por destruir os portões quando o boss morre


    // Start is called before the first frame update
    public GameObject chefe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!chefe )
        {
            Destroy(gameObject);
        }
    }
}
