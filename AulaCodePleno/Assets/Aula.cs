using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Aula : MonoBehaviour
{
  #region   Aula de Variaveis e funções
    //Tipos de Variáveis - 
    //int - para valores inteiros
    //float - para valores reais, ou seja, com virgula
    //boll - para valores verdadeiro (true) ou falso (false)
    //string - para escrever textos
   /* public int idade = 15, vida = 3, stamina = 4;
    public float altura = 1.75f, velocidade = 5f;
    public bool vivo = true;
    public string nome_presonagem = "João", nome_inimigo = "Gigante";

    public void Atacar()
    {
        if (vida > 0)
        {
            Debug.Log("Vida: " + vida +  "\n Atacando....");
            
        }
    }*/
#endregion
  #region   Aula Condicionais
     
     int vida = 5;

    int HitTomado() // Método com retorno 
    {
        int hit = 1;
        return hit; 
    }

    public void MostrandoHit() // Metodo sem retorno
    {
       vida -= HitTomado(); //vida = vida - HitTomado();
       Debug.Log("Vida depois do Hit" + vida);
    }

    int numero = 0;
    bool condicao = false;
    bool condicao2 = true;


   public void AtribuirValor()
    {
        //numero = condicao ? 1 : condicao2 ? 3 : 2;

        if (condicao)
        {
            numero = 1;
        }
        if(condicao2)
        {
            numero = 3;
        }
        else
        {
            numero = 2;
        }
       

       switch (numero)
        {
            case 1:
              Debug.Log("Número recebeu o valor de: " + numero);
            break;

            case 2: 
              Debug.Log("Número recebeu o valor de: " + numero);
           break;

            case 3:
              Debug.Log("Número recebeu o valor de: " + numero);
            break;
            case 4:
               Debug.Log("Número recebeu o valor de: " + numero);
            break;

            default:
             Debug.Log("Aula de Metodos e Condicionais");
            break;

        }



         
    }




  #endregion

   void Start()
    {
      AtribuirValor();
       
    }


    void Update()
    {
      
    }
}