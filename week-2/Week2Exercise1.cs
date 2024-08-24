using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Exercise1 : MonoBehaviour
{

    /*
     En el sistema interno de un juego de estrategia, se genera un n�mero entero positivo que se usa para determinar el camino que tomara una IA. 
    Debemos indicar si el n�mero ingresado es par, ya que de serlo la IA tomara una acci�n diferente a la estipulada de forma convencional. 
    */

    public int randomNumber;


    void Start()
    {
        randomNumber = Random.Range(0, 10);

        if (randomNumber % 2 == 0)
        {
            print("El n�mero es par");
        }
        else
        {
            print("El n�mero es impar");
        }
        
    }
}
