using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{
    // FUNCIONES

    //VARIABLES

    //FUNCIONES con inputs

   
    private void SayHello(string name)
    {
        Debug.Log($"hello,{name}");
    }

    //Funcion con outputs y inputs

    private int Sumatory (int num1, int num2, int num3)
    {
        int result = num1 + num2 + num3;
        return result;
    }

    //codigo
    private void Start()
    {
        SayHello("pepito");
        SayHello("Maripili");
        SayHello("Esternocleidomastoideo");
    }

}
