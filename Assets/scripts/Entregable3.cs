using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entregable3 : MonoBehaviour
{
    //variables ejercicio 1 y 3

   [SerializeField] private int num1 = 4;
   [SerializeField] private int num2 = 8;

    //variables ejercicio 2

    [SerializeField] private string letter = "A";

    //variables ejercicio 4

    [SerializeField] private string grade = "A";

    //variables ejercicio 5

    [SerializeField] private int days = 0; 
    [SerializeField] private int months = 0;
    [SerializeField] private int years = 0;




    private void Start()
    {
       
        //ejercicio 1

       if (num1>num2)
        {
            Debug.Log("the first number is biger than the second");
        }
       else if(num2>num1)
        {
            Debug.Log("num2 is biger than num1");

        }

        //ejercicio 2

        if (letter == "A" || letter == "E" || letter == "I" || letter == "O" || letter == "U")
        {
            Debug.Log($" the letter {letter} is a vowel");
        }
        else
        {
            Debug.Log($" the letter {letter} is a consonant");
        }

        //ejercicio 3

        if (num1%num2 == 0)
        {
            Debug.Log($"{num1} is divisible by {num2}"); 
        }
        else
        {
            Debug.Log($"{num1} is not divisible by {num2}");
        }

        //ejercicio 4

        if (grade=="A")
        {
            Debug.Log("excellent");
        }
        else if(grade=="B")
        {
            Debug.Log("notable");
        }
        else if (grade == "C")
        {
            Debug.Log("passed");
        }
        else if (grade == "D")
        {
            Debug.Log("fail");
        }

        //ejercicio 5


        if (months == 1 || months == 3 || months == 5 || months == 7 || months == 9 || months == 11)
        {
            if (days <= 31 && days > 0 && years>0)
            {
                Debug.Log($" {days} / {months} / {years} is a valid date");
            }
            else
            {
                Debug.Log(" this is not a valid date");
            }

        }
        else if (months == 2)
        {
            if(days<=28 && days >0 && years>0)
            {
                Debug.Log($" {days} / {months} / {years} is a valid date");
            }
            else
            {
                Debug.Log(" this is not a valid date");
            }

        }
        else if (months == 4|| months ==6 || months ==8 || months ==10 || months  ==12)
        {
            if (days <= 30 && days > 0 && years > 0)
            {
                Debug.Log($" {days} / {months} / {years} is a valid date"); 
            
            }
            else
            {
                Debug.Log(" this is not a valid date");
            }
        }
        else
        {
            Debug.Log("this is not a valid date");
        }

        //ejercicio 6

        if (years%12 ==0)
        {

        }
























    }
}
