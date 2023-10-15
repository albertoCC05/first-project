using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entregable2 : MonoBehaviour
{
    //Declaracion de variables (ejercicio 1)

    [SerializeField] private float number1;
    [SerializeField] private float number2;

    //variable para ejercicio 4

    [SerializeField] private bool comparationNumbers = false;

    //ejercicio 5

    private string playerName = "alberto";

    //ejercicio8

    [SerializeField] private int number3;
    [SerializeField] private int number4;


    private void Start()
    {
        //ejercicio 2

        Debug.Log(number1+number2);

        //ejercicio 3
        if (number1 >= number2)
        {
            Debug.Log($"{number1} is greater or equal than {number2}");
        }
        else
        { Debug.Log($"{number1} is not greater or equal than {number2}"); }

        //ejercicio 4

        if (number1>=number2)
        {
            comparationNumbers = true;
            Debug.Log($"{number1} is greater or equal than {number2}? {comparationNumbers}"); }
         else
        {
            comparationNumbers = false;
            Debug.Log($"{number1} is greater or equal than {number2}? {comparationNumbers}");
        }

        //ejercicio 6

        Debug.Log($"welcome {playerName}");

        //ejercicio 8

        Debug.Log(number3 % number4);

        //ejercicio 9

        Debug.Log($"hello my name is {playerName}");

     }

    /* ejercicio 10
     
    -para el ejercicio 1 y 2 he creado dos variables llamadas number1 y number 2 y con el codigo Debug.Log() las he sumado y mostrado por consola
     - el ejercicio 3 he creado el codigo if con la condicion de si el number1 era mayor o igual a number2 que se mostrara en consola el mensaje de que number1 es mayor o igual a number 2 y tambien cree un else
    de tal manera que si la condicion del if no dse cumplia saliera un mensaje de que el number1 no es mayor o igual a number2.
    -para el ejercicio 4 cree una variable de tipo bool (true/false) y segui el procedimiento del ejercicio 3 con la difeencia de que si se cumplia
    o no la condicion saliera los resultados de la variable bool llamada compareNumbers.
    -ejercicio 5 y 6 he creado una variable de tipo string que contenga mmi nimbre y con el codigo Debug.Log he mostrado
    mi nombre en consola
    -para el ejercicio 7 y 8 he creado dos variables tipo int llamadas number3 y number 4 y he mostrado por consola
    el resultado de calcular el modulo (number4) de number3 
    -para el ejercicio9 he mostrado por consola el mensaje de hello my name is (playerName) donde player name hace referencia al nombre que puese en este caso alberto*/
    

    


    }



