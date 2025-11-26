using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aula : MonoBehaviour
{
  #region   Aula de Variaveis e funções
    //Tipos de Variáveis - 
    //int - para valores inteiros
    //float - para valores reais, ou seja, com virgula
    //boll - para valores verdadeiro (true) ou falso (false)
    //string - para escrever textos
    public int idade = 15, vida = 3, stamina = 4;
    public float altura = 1.75f, velocidade = 5f;
    public bool vivo = true;
    public string nome_presonagem = "João", nome_inimigo = "Gigante";

    public void Atacar()
    {
        if (vida > 0)
        {
            Debug.Log("Vida: " + vida +  "\n Atacando....");
            
        }
    }
#endregion


   void Start()
    {
      
       
    }


    void Update()
    {
      
    }
}