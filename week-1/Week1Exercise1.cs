using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    1. Dado el da�o base de un personaje, realice un programa que calcule su da�o cr�tico sabiendo que la f�rmula es: DC=(da�obase)�+80% del da�o base 
 */

public class Week1Exercise1 : MonoBehaviour
{
    public float baseDamage = 10f;

    public float criticBonus = 0.8f;

    void Start()
    {
        float finalDamage = (baseDamage * baseDamage) + baseDamage * criticBonus;

        print("Daño crítico: " + finalDamage);
    }
}
