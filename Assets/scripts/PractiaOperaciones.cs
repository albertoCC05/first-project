using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PractiaOperaciones : MonoBehaviour
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private int num3;
    [SerializeField] private int num4;

    private void Start()
    {
        Debug.Log($"tengo [{num3 % 3} monedas");
        Debug.Log($"tengo [{num4 % 3} monedas");




    }
}
