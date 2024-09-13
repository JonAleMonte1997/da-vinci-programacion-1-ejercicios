using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Exerceise3 : MonoBehaviour
{
    /*
    En el mismo juego del ejercicio anterior, al finalizar la partida se muestra a los jugadores y el nivel que alcanzaron, el cual es aleatorio entre 2 y 10. 
    Indicar si se muestran ordenados de forma creciente, decreciente, si todos tienen el mismo nivel o si no se respeta ningun tipo de orden.
    */

    public int player1Level;
    public int player2Level;
    public int player3Level;

    void Start()
    {
        player1Level = Random.Range(2, 10);
        player2Level = Random.Range(2, 10);
        player3Level = Random.Range(2, 10);

        if(player1Level < player2Level && player2Level < player3Level)
        {
            print("Los niveles están ordenados de forma creciente");
        } else if (player1Level > player2Level && player2Level > player3Level)
        {
            print("Los niveles están ordenados de forma decreciente");
        } else if (player1Level == player2Level && player2Level == player3Level)
        {
            print("Todos tienen el mismo nivel");
        } else
        {
            print("No se respeta ningun tipo de orden");
        }

    }
}
