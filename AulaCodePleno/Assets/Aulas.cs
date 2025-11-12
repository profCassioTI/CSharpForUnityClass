using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aulas : MonoBehaviour
{
    //Tipos de Variáveis - 
    //int - para valores inteiros
    //float - para valores reais, ou seja, com virgula
    //boll - para valores verdadeiro (true) ou falso (false)
    //string - para escrever textos
    public int idade = 0;
    public float altura = 0;
    private int vida = 3;
    public int stamina = 4;
    public float velocidade = 5;
    public bool vivo = true;
    public string nome = "";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Olá Mundo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
