﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateDano : MonoBehaviour
{
    public delegate void AumentaDano();
    public AumentaDano aumentaDano;
    public static DelegateDano instance;
    
    
    //Usando a instância do delegate dano para aumentar o dano que os inimigos recebem quando o player
    //upa o dano 


    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        
    }
    public void ClickDano()
    {
        aumentaDano();
    }
}
