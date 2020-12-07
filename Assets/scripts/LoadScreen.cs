﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{

    // Responsável pelo teleporte do player da fase inicial para a cena da vitória


    Scene cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        cena = SceneManager.GetActiveScene();
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(cena.buildIndex - 1);
        }
        
    }
}
