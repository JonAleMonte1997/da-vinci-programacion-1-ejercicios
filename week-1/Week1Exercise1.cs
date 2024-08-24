using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    1. Dado el daño base de un personaje, realice un programa que calcule su daño crítico sabiendo que la fórmula es: DC=(daño base)^2 + 80% del daño base 
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
