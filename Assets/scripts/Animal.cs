using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private int numberLegs = 4;
    [SerializeField] private string animalName = "dog";

    private void Start()
    {
        Debug.Log($"el animal {animalName} tiene {numberLegs} patas");
    }

}
