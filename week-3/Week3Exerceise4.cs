using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Exerceise4 : MonoBehaviour
{
    /*
    En un juego de dúos, se usa un algoritmo que revisa los puntos de los jugadores del equipo para otorgarles, en el caso de que corresponda, un bonus. 
    Dicho algoritmo comprueba lo siguiente: 
        a. Si ambos puntajes son pares o si el primero es par y el segundo impar, indicar “bonus conseguido” y sumarle a cada jugador un 5% de sus puntos. 
        b. Caso contrario indicar “el bonus no fue otorgado”. 
        c. Considere que los puntos de cada jugador varían entre 1000 y 2500.
    */

    public float player1Points;
    public float player2Points;

    void Start()
    {
        player1Points = Random.Range(1000, 2500);
        player2Points = Random.Range(1000, 2500);

        print("Jugador 1 puntos: "+player1Points+" Jugador 2 puntos: "+player2Points);

        if (player1Points % 2 == 0)
        {
            print("Bonus conseguido");
            player1Points *= 1.05F;
            player2Points *= 1.05F;
        } else
        {
            print("El bonus no fue otorgado");
        }
    }
}
