﻿using System;
using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DanoVida : MonoBehaviour
{
    //Responsavel pela vida dos inimigos

    // Start is called before the first frame update
    public int dano;
    public int danoEspecial=20;
    public int vidamaxima;
    public int vidaatual;
    public PlayerLevelSystem player;
    public BarraVida barravida;
    public int xp_to_give;
    public DelegateDano delegatedano;



    void Start()
    {
        //usando o Delegate para aumentar o dano recebido quando o Player upa seu dano
        delegatedano = DelegateDano.instance;
        delegatedano.aumentaDano += UpDano;

        vidaatual = vidamaxima;
        barravida.VidaMaxima(vidamaxima);

        //busca o XPmanager na cena
        Invoke("FindXPManager", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //se morre dá xp para o player e destroi ele
        if (vidaatual <= 0)
        {
            if(player != null)
            {

                player.SendMessage("XPTrigger", xp_to_give);
            }

            //remove o inimigo da lista do botao UPDano
            delegatedano.aumentaDano -= UpDano;


            Destroy(gameObject);
        };
        
        
    }

   
    //dano de tiro normal e especial (bomba é especial)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
            Dano(dano);
        if (collision.gameObject.CompareTag("Bomba"))
            Dano(danoEspecial);
    }
    public void Dano(int xDmg)
    {
        vidaatual -= xDmg;
        barravida.SetVida(vidaatual);
    }


    //Funcao para o botao no PanelLevelUp
    public void UpDano()
    {
        dano += 5;
    }


    public void FindXPManager()
    {
        player = GameObject.Find("XPManager").GetComponent<PlayerLevelSystem>();
    }
}   
