using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ScriptsCondiciones : MonoBehaviour
{
    //operador de decision "if" condicion

    [SerializeField] private float vidas =0;
    [SerializeField] private float num = 0;
    [SerializeField] private float age = 0;
    [SerializeField] private string characterName;

    private void Start()
    {
        if (vidas <= 0) 
        {
            Debug.Log("has perdido");

        }

        if (num % 2 == 0)
        {
            Debug.Log($"{num} es par");


        }
        if (age >= 18)
        {
            Debug.Log($" {characterName} es mayor de edad");
        }
        else
        { Debug.Log($" {characterName} es menor de edad");
         }
    }



}
