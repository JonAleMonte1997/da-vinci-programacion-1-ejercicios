using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3Exerceise2 : MonoBehaviour
{
    /*
    En un juego cooperativo de tres jugadores, al finalizar la expedici�n se debe comprobar cual de los tres obtuvo m�s oro, siendo que cada uno puede tener entre 50 y 200 de oro. 
    Indicar cual obtuvo m�s.  
    */

    public int player1Gold;

    public int player2Gold;

    public int player3Gold;

    void Start()
    {
        player1Gold = Random.Range(50, 200);
        player2Gold = Random.Range(50, 200);
        player3Gold = Random.Range(50, 200);

        if (player1Gold > player2Gold && player1Gold > player3Gold)
        {
            print("El jugador 1 obtuvo m�s oro");
        } else if (player2Gold > player1Gold && player2Gold > player3Gold)
        {
            print("El jugador 2 obtuvo m�s oro");
        } else if (player3Gold > player1Gold && player3Gold > player2Gold)
        {
            print("El jugador 3 obtuvo m�s oro");
        } else
        {
            print("No hubo un jugador puntual con m�s oro que todos");
        }
    }
}
