using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Exercise4 : MonoBehaviour
{
    /*
    En un juego donde se define al ganador seg�n los puntos que adquiere durante la partida, existe un potenciador de puntos que aparece una sola vez por partida y 
    cuyo efecto es multiplicar por tres los puntos actuales del jugador y sumarle la mitad de sus puntos originales. 
    Tenga en cuenta que el potenciador solo surte efecto si el jugador tiene por lo menos 250 puntos.
    */

    public int playerPoints = 500;

    public bool bonusWasActivated = false;

    void Start()
    {
        if (playerPoints >= 250 && !bonusWasActivated)
        {
            playerPoints = playerPoints * 3 + playerPoints / 2;
            bonusWasActivated = true;
        }

        print("Puntuación final: " + playerPoints);
    }
}
