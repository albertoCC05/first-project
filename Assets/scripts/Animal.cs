using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int numberLegs = 4;
    [SerializeField] private string animalName = "dog";
     private bool numeroPatorrasIgualA4 = true;

    private void Start()
    {
        Debug.Log($"el animal {animalName} tiene {numberLegs} patas");

        if (numberLegs ==4)
        {
            Debug.Log($"el perro tiene 4 patas {numeroPatorrasIgualA4}");

           
        }  
    }

}
