using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Entrega4 : MonoBehaviour
{
    //variables

    // ejercicio 1 y 10

    [SerializeField] private int num1;
    [SerializeField] private int num2;

    //ejercicio 3

    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;

    //ejercicio 5 y 6

    [SerializeField] private int day2;
    [SerializeField] private int month2;
    [SerializeField] private int year2;
    [SerializeField] private int day3;
    [SerializeField] private int month3;
    [SerializeField] private int year3;


    //ejercicio 8

    [SerializeField] private float BaseTriangleMesure;
    [SerializeField] private float HeigthTriangleMesure;

    // ejercicio 9

    [SerializeField] private float grade;


    //Funciones

    //ejercicio 1

    private void CompareNumbers()
    {
        if (num1 > num2)
        {
            Debug.Log($" {num1} is biger than {num2}");
        }
        else if (num1 < num2)
        {
            Debug.Log($" {num1} is lower than {num2}");
        }
    }

    // ejercicio 2

    private void VowelOrConsonant ( string letter)
    {
       
        
        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" )
        {
            Debug.Log($"´{letter} is a vowel");
        }
        else
        {
            Debug.Log($"´{letter} is a consonant");
        }
    }
    
    //ejercicio 3


    private void ValidDate( bool valid)
    {
        if (month ==1 || month==3 || month==5 || month==7 || month==8 || month==10 || month==12)
        {
            if ( day >= 1 && day <=31)
            {
                valid = true;

                Debug.Log(valid);
            }
             else
            {
                valid = false;

                Debug.Log(valid);
            }
        }
        if (month == 2)
        {
            if (day >= 1 && day <= 28)
            {
                valid = true;

                Debug.Log(valid);
            }
            else
            {
                valid = false;

                Debug.Log(valid);
            }
        }
        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            if (day >= 1 && day <= 30)
            {
                valid = true;

                Debug.Log(valid);
            }
            else
            {
                valid = false;

                Debug.Log(valid);
            }
        }
    }

    //ejercicio 4

    private void LeapYear(bool leapYear)
    {
        if( year % 4 == 0)
        {
            leapYear = true;

            Debug.Log(leapYear);

        }
        else
        {
            leapYear = false;

            Debug.Log(leapYear);

        }
    }

    // ejercicio 5

    

    // ejercicio 6



    // ejercicio 7

    private void ChineseHoroscope()
    {
        if (year % 12 == 0)
        {
            Debug.Log("tu horoscopo chino es mono");
        }
        else if (year % 12 == 1)
        {
            Debug.Log("tu horoscopo chino es gallo");
        }
        else if (year % 12 == 2)
        {
            Debug.Log("tu horoscopo chino es perro");
        }
        else if (year % 12 == 3)
        {
            Debug.Log("tu horoscopo chino es cerdo");
        }
        else if (year % 12 == 4)
        {
            Debug.Log("tu horoscopo chino es rata");
        }
        else if (year % 12 == 5)
        {
            Debug.Log("tu horoscopo chino es buey");
        }
        else if (year % 12 == 6)
        {
            Debug.Log("tu horoscopo chino es tigre");
        }
        else if (year % 12 == 7)
        {
            Debug.Log("tu horoscopo chino es conejo");
        }
        else if (year % 12 == 8)
        {
            Debug.Log("tu horoscopo chino es dragon");
        }
        else if (year % 12 == 9)
        {
            Debug.Log("tu horoscopo chino es serpiente");
        }
        else if (year % 12 == 10)
        {
            Debug.Log("tu horoscopo chino es caballo");
        }
        else
        {
            Debug.Log("tu horoscopo chino es cabra");
        }
    }

    //ejercicio 8

    private void TriangleArea()
    {
        Debug.Log((HeigthTriangleMesure * BaseTriangleMesure) / 2);
    }

    //ejercicio 9

    private void Grade()
    {
        if (grade >=9 && grade < 11)
        {
            Debug.Log(" your grade is a A");
        }
        if (grade >= 7 && grade < 9)
        {
            Debug.Log(" your grade is a B");
        }
        if (grade >= 5 && grade < 7)
        {
            Debug.Log(" your grade is a C");
        }
        else if (grade >=0 && grade <5)
        {
            Debug.Log(" your grade is a D");
        }
    }

    // 10

    private void EvenOdd()
    {
        if (num1 % 2 == 0)
        {
            Debug.Log($" {num1} is even");
        }
        else
        {
            Debug.Log($" {num1} is odd");
        }
    }

    //ejercicio 5 otra vez

    private void AddAMonth()
    {

        month2 = month2 + 1;

    }
    private void AddAYear()
    {

        
        
         year2 = year2 + 1;
        


    }

    
    private void addADay()
    {
        day2 = day2 + 1;

        

        if (month2 == 1 || month2 == 3 || month2 == 5 || month2 == 7 || month2 == 8 || month2 == 10 || month2 == 12)
        {
            if (day2 > 31)
            {
                day2 = 1;
                AddAMonth();

                if (month2 > 12)
                {
                    AddAYear();
                    month2 = 1;

                }
                
            }
        }
        else if (month2 == 2)
        {
            if (day2 > 28)
            {

                day2 = 1;
                AddAMonth();
                



            }
        }
        else if (month2 == 4 || month2 == 6 || month2 == 9 || month2 == 11)
        {
            if (day2 > 30)
            {
                day2 = 1;
                AddAMonth();

              

            }
        }
        Debug.Log($" the date is {day2} / {month2} / {year2}");

    }

    //ejercicio 6

    private void SubstractADay()
    {

    }






    private void Start()
    {
        // 1

        CompareNumbers();

        // 2

        VowelOrConsonant ("a");
        VowelOrConsonant("z" );

        // 3

        ValidDate(false);

        //4

        LeapYear(true);

        //5

        addADay();

        //6



        // 7

        ChineseHoroscope();

        // 8

        TriangleArea();

        // 9 

        Grade();

        // 10

        EvenOdd();

     

        


    }


}
