using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Exerceise1 : MonoBehaviour
{
    /*
    Se quiere verificar si un personaje est� vivo despu�s de recibir un golpe, esto se hace bajo la siguiente premisa: si la vida del personaje es positiva indicar que esta vivo, si es negativa 
    indicar que est� muerto, pero si es cero debe indicar que esta en el limbo luchando por su vida. Considere el valor de la vida de forma aleatoria entre -25 y 100.  
    */

    public int personLife;

    void Start()
    {
        personLife = Random.Range(-25, 100);

        if (personLife > 0 )
        {
            print("El personaje est� vivo");
        } else if (personLife == 0 )
        {
            print("El personaje esta en el limbo lucnahdo por su vida");
        } else if (personLife < 0)
        {
            print("El personaje est� muerto");
        }
    }
}
