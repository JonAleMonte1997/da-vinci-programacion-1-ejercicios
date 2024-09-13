using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week5Exerceises : MonoBehaviour
{

    public int punch = 0;
    public int punchDamage;
    public int totalDamage = 0;

    public int punchExercise2 = 0;
    public int punchDamageExercise2;
    public int totalDamageExercise2;
    public int enemyLife = 2500;

    public int wave = 0;
    public int totalEnemiesInWave;
    public int playerKills;
    public int totalEnemiesAlive = 0;
    public int totalEnemiesGenerated = 0;

    public int punchDamageExercise4;
    public int totalConsecutivePunches = 0;
    public int totalDamageExercise4 = 0;

    void Start()
    {
        #region ejercicio1
        /*
         En un juego de pelea, un personaje (Seiya) utiliza una habilidad que se llama �Meteoro de Pegaso� y que funciona de esta manera:  
            Paso1: El contrincante recibir� 10 golpes. 
            Paso 2: Cada uno de esos golpes proporciona un da�o que var�a entre 1000 y 2000 de manera aleatoria. 
            a. Muestre cual fue el da�o recibido por el contrincante en cada golpe. 
            b. Muestre el da�o total final que el enemigo recibi�. 
         */

        while (punch < 10)
        {
            punch++;

            punchDamage = Random.Range(1000, 2001);

            totalDamage += punchDamage;

            print("Da�o del golpe " + punch+ " es de " + punchDamage);
        }

        print("Da�o total: " + totalDamage);

        #endregion

        #region ejercicio2
        /*
         Programe la habilidad de un personaje que pega golpes consecutivos hasta que el contrincante fallezca o se superen los 10 golpes. Cada golpe proporcionado con dicha 
        habilidad var�a entre 100 y 500 de da�o. La vida del contrincante es de 2500. 
            a. Indique, en caso de que el enemigo no haya muerto, cu�l es su vida resultante, y cu�l fue el da�o recibido. 
            b. Indique, en caso de que el enemigo haya muerto, cuantos golpes se necesit� para matarlo. 
            c. En todos los casos el programa deber� mostrar el da�o parcial acumulado y la vida actual del contrincante. 
         */

        while(enemyLife > 0 && punchExercise2 < 10)
        {
            punchDamageExercise2 = Random.Range(100, 501);
            enemyLife -= punchDamageExercise2;
            totalDamageExercise2 += punchDamageExercise2;
            punchExercise2++;
        }

        if (enemyLife > 0)
        {
            print("El enemigo sobrevivio con vida: " + enemyLife + ", recibi� un da�o total de: " + totalDamageExercise2);

        } else
        {
            print("El enemigo murio y se necesit� un total de " + punchExercise2 + " golpes para matarlo");
        }

        print("El da�o acumulado fue de " + totalDamageExercise2 + " y el enemigo qued� con una vida actual de " + enemyLife);

        #endregion

        #region ejercicio3
        /*
         Realice un programa que genere 10 oleadas de enemigos que var�an entre 10 y 100. 
        Por cada oleada el jugador eliminara un numero aleatorio de enemigos de la misma. Al finalizar las oleadas indique:  
            a. �Cu�ntos enemigos fueron generados? 
            b. �Cu�ntos enemigos quedan vivos? 
            c. En cada oleada el programa deber� indicar �Se generaron X enemigos�. 
         */

        while(wave < 10)
        {
            wave++;

            totalEnemiesInWave = Random.Range(10, 101);

            print("Se generaron " + totalEnemiesInWave + " enemigos.");

            playerKills = Random.Range(0, totalEnemiesInWave + 1);

            totalEnemiesAlive += totalEnemiesInWave - playerKills;

            totalEnemiesGenerated += totalEnemiesInWave;
        }

        print("Se generaron un total de " + totalEnemiesGenerated + " enemigos.");
        print("Quedaron vivos un total de " + totalEnemiesAlive + " enemigos.");

        #endregion

        #region ejercicio4
        /*
         Programe la habilidad de un personaje que pegue golpes consecutivos hasta que alguno sea errado (da�o cero). El da�o de cada golpe var�a entre 0 y 10. Indique:  
            a. Cual fue el da�o otorgado al enemigo. 
            b. Cuantos golpes consecutivos se asestaron. 
            c. Cada vez que se genere un golpe mostrar cual fue el da�o generado.
         */

        do
        {
            punchDamageExercise4 = Random.Range(0, 11);

            totalDamageExercise4 += punchDamageExercise4;

            if (punchDamageExercise4 > 0)
            {
                totalConsecutivePunches++;
                print("Golpe " + totalConsecutivePunches + " hizo un da�o total de: " + punchDamageExercise4);
            }

        } while (punchDamageExercise4 > 0);

        print("Se conectaron un total de " + totalConsecutivePunches + " golpes");
        print("El da�o total fue de " + totalDamageExercise4);

        #endregion
    }
}
