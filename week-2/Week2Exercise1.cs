using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Exercise1 : MonoBehaviour
{

    /*
     En el sistema interno de un juego de estrategia, se genera un número entero positivo que se usa para determinar el camino que tomara una IA. 
    Debemos indicar si el número ingresado es par, ya que de serlo la IA tomara una acción diferente a la estipulada de forma convencional. 
    */

    public int randomNumber;


    void Start()
    {
        randomNumber = Random.Range(0, 10);

        if (randomNumber % 2 == 0)
        {
            print("El número es par");
        }
        else
        {
            print("El número es impar");
        }
        
    }
}
