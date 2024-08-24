using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
  Dada la vida de un personaje, indique si es urgente curarlo o no (true / false), teniendo en cuenta que si tiene menos del 30% debe ser curado, su vida m�xima es de 150.
 */
public class Week1Exercise2 : MonoBehaviour
{

    public float maxHealth = 150f;

    public float currentHealth = 45f;

    void Start()
    {
        if (currentHealth < maxHealth * 0.3f)
        {
            print("Necesita curación");
        }
        else
        {
            print("No necesita curación");
        }
    }
}
