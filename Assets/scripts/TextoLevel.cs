﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextoLevel : MonoBehaviour
{

    // Responsável pelos botões, sliders e texto do canvas "level up"


    public Text txtAtual;
    public Text txtProximo;
    public Text txtParabens;

    public Slider sliderDano;
    public Slider sliderVida;
    public Slider sliderMovSpeed;

    public Button btDano;
    public Button btVida;
    public Button btMovSpeed;

    //public PlayerLevelSystem level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Responsável pelo nível do player
        txtParabens.text = XpManager.level.currentLevel.ToString();

        sliderDano.value = XpManager.lvldano;
        sliderVida.value = XpManager.lvlvida;
        sliderMovSpeed.value = XpManager.lvlmovSpeed;
        

        if (sliderVida.value >= 5)
        {            
            btVida.interactable = false;            
        }

        if (sliderDano.value >= 5)
        {
            btDano.interactable = false;
        }

        if (sliderMovSpeed.value >= 5)
        {
            btMovSpeed.interactable = false;
        }


    }
}
