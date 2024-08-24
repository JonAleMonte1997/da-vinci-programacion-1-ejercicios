using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 En un juego de administración de una estación de tren, se quiere saber la siguiente información sobre un tren que esta por partir para la pantalla de métricas:
    a. Si el tren que esta por partir tiene un total de vagones par (ingrese de forma manual el número de vagones).
    b. Cuantos pasajeros viajan en el tren, sabiendo que en cada vagón entran 50 personas
 */
public class Week1Exercise3 : MonoBehaviour
{

    public int wagons = 2;

    public int passengersPerWagon = 50;

    void Start()
    {

        int numberOfPassengers = wagons * passengersPerWagon;

        if (wagons % 2 == 0)
        {
            print("El tren tiene una cantidad de vagones par");
        }

        print("Pasajeros totales: " + numberOfPassengers);
    }
}
