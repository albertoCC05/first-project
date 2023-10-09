using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{  
    // variables practica
    
    private int age = 18;

    private float speed = 1.5f;

    private bool isgameover = false;

    private string playername = "Alberto";
    
    

    private void Start()
    {
        //comentarios en consola
        Debug.Log("buenas tardes por la mañana");
        Debug.Log($"El nombre de el jugador es:{playername}");
        Debug.Log(speed);
        Debug.Log(age);
        Debug.Log(isgameover);
        //operaciones, operaciones aritmeticas

        

    }




}
