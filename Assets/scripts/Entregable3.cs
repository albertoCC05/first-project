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

    //variables ejercicio 5, 6 y 7

    [SerializeField] private int days = 0; 
    [SerializeField] private int months = 0;
    [SerializeField] private int years = 0;

    // variable ejercicio 8

    [SerializeField] private string weekDay;

    //variables ejercicio 9

    [SerializeField] private int age = 0;
    [SerializeField] private string memberRank;

    // varables ejercicio 10

    [SerializeField] private float angle1;
    [SerializeField] private float angle2;
    [SerializeField] private float angle3;


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
            Debug.Log("tu horoscopo chino es mono");
        }
        else if (years%12 ==1)
        {
            Debug.Log("tu horoscopo chino es gallo");
        }
        else if (years % 12 == 2)
        {
            Debug.Log("tu horoscopo chino es perro");
        }
        else if (years % 12 == 3)
        {
            Debug.Log("tu horoscopo chino es cerdo");
        }
        else if (years % 12 == 4)
        {
            Debug.Log("tu horoscopo chino es rata");
        }
        else if (years % 12 == 5)
        {
            Debug.Log("tu horoscopo chino es buey");
        }
        else if (years % 12 == 6)
        {
            Debug.Log("tu horoscopo chino es tigre");
        }
        else if (years % 12 == 7)
        {
            Debug.Log("tu horoscopo chino es conejo");
        }
        else if (years % 12 == 8)
        {
            Debug.Log("tu horoscopo chino es dragon");
        }
        else if (years % 12 == 9)
        {
            Debug.Log("tu horoscopo chino es serpiente");
        }
        else if (years % 12 == 10)
        {
            Debug.Log("tu horoscopo chino es caballo");
        }
        else 
        {
            Debug.Log("tu horoscopo chino es cabra");
        }

        //ejercicio 7

        if (months==1 && days>=1 && days<20)
        {

            Debug.Log("tu horoscopo es capricornio");
        }
        else if (months == 1 && days >= 20 && days < 32)
        {

            Debug.Log("tu horoscopo es acuario");
        }
        else if (months == 2 && days >= 1 && days < 19)
        {

            Debug.Log("tu horoscopo es acuario");
        }
        else if (months == 2 && days >= 19 && days < 29)
        {

            Debug.Log("tu horoscopo es piscis");
        }
        else if (months == 3 && days >= 1 && days < 21)
        {

            Debug.Log("tu horoscopo es piscis");
        }
        else if (months == 3 && days >=21  && days < 32)
        {

            Debug.Log("tu horoscopo es aries");
        }
        else if (months == 4 && days >= 1 && days < 20)
        {

            Debug.Log("tu horoscopo es aries");
        }
        else if (months == 4 && days >= 21 && days < 31)
        {

            Debug.Log("tu horoscopo es tauro");
        }
        else if (months == 5 && days >= 1 && days < 21)
        {

            Debug.Log("tu horoscopo es tauro");
        }
        else if (months == 5 && days >= 21 && days < 32)
        {

            Debug.Log("tu horoscopo es geminis");
        }
        else if (months == 6 && days >= 1 && days < 21)
        {

            Debug.Log("tu horoscopo es geminis");
        }
        else if (months == 6 && days >= 21 && days < 31)
        {

            Debug.Log("tu horoscopo es cancer");
        }
        else if (months == 7 && days >= 1 && days < 23)
        {

            Debug.Log("tu horoscopo es cancer");
        }
        else if (months == 7 && days >= 23 && days < 32)
        {

            Debug.Log("tu horoscopo es leo");
        }
        else if (months == 8 && days >= 1 && days < 23)
        {

            Debug.Log("tu horoscopo es leo");
        }
        else if (months == 8 && days >= 23 && days <32 )
        {

            Debug.Log("tu horoscopo es virgo");
        }
        else if (months == 9 && days >= 1 && days < 23)
        {

            Debug.Log("tu horoscopo es virgo");
        }
        else if (months == 9 && days >= 23 && days < 31)
        {

            Debug.Log("tu horoscopo es libra");
        }
        else if (months == 10 && days >= 1 && days < 23)
        {

            Debug.Log("tu horoscopo es libra");
        }
        else if (months == 10 && days >= 23 && days < 32)
        {

            Debug.Log("tu horoscopo es escorpio");
        }
        else if (months == 11 && days >= 1 && days < 22)
        {

            Debug.Log("tu horoscopo es escorpio");
        }
        else if (months == 11 && days >=22 && days < 31)
        {

            Debug.Log("tu horoscopo es sagitario");
        }
        else if (months == 12 && days >= 1 && days < 22)
        {

            Debug.Log("tu horoscopo es sagitario");
        }
        else if (months == 12 && days >= 22 && days < 32)
        {

            Debug.Log("tu horoscopo es capricornio");
        }

        //ejercicio 8

        if (weekDay == "monday" || weekDay == "tuesday" || weekDay == "wednesday" || weekDay =="thursdat" || weekDay == "friday")
        {
            Debug.Log("is not weekwnd");
        }
        else
        {
            Debug.Log("is weekend");
        }

       //ejercicio 9

        if (age>=18 && age<65)
        {
            if(memberRank=="gold")
            {
                Debug.Log("you have  75% of discount");
            }
           else if (memberRank == "silver")
            {
                Debug.Log("you have  50% of discount");
            }
            else if (memberRank == "bronze")
            {
                Debug.Log("you have  25% of discount");
            }

        }
        else if (age > 65)
        {
            if (memberRank == "gold")
            {
                Debug.Log("you have  50% of discount");
            }
            else if (memberRank == "silver")
            {
                Debug.Log("you have  25% of discount");
            }
            else if (memberRank == "bronze")
            {
                Debug.Log("you have  15% of discount");
            }
        }
        else if (age < 18)
        {
            Debug.Log("you cant buy in these shop due to you are a minor");
        }

        //ejercicio 10


        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log("theese angles can be the internal angles of a triangle");
        }
        if (angle1 + angle2 + angle3 == 180)
        {
            Debug.Log("theese angles can't be the internal angles of a triangle");
        }


















    }
}
