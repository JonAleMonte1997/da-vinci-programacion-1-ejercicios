using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week4Exerceises : MonoBehaviour
{
    public int mapNumber;

    public string inputName = "Juan";

    public int evalutationNote;


    void Start()
    {
        #region ejercicio1

        //Ejercicio 1: Dado un número de mapa que puede variar entre 0 y 5, mostrar por pantalla el número de mapa seleccionado en forma de texto.  Ej: 1 -> “Mapa uno”.

        mapNumber = Random.Range(0, 6);

        print("###### EJERCICIO 1 con IF ######");

        if (mapNumber == 0 )
        {
            print("Mapa cero");

        } else if (mapNumber == 1 )
        {
            print("Mapa uno");

        } else if (mapNumber == 2 )
        {

            print("Mapa dos");

        } else if (mapNumber == 3 )
        {
            print("Mapa tres");

        } else if (mapNumber == 4 )
        {
            print("Mapa cuatro");

        } else if (mapNumber == 5 )
        {
            print("Mapa cinco");
        }

        print("###### EJERCICIO 1 con SWITCH ######");

        switch (mapNumber)
        {
            case 0:
                print("Mapa cero");
                break;
            case 1:
                print("Mapa uno");
                break;
            case 2:
                print("Mapa dos");
                break;
            case 3:
                print("Mapa tres");
                break;
            case 4:
                print("Mapa cuatro");
                break;
            case 5:
                print("Mapa cinco");
                break;
        }

        #endregion

        #region ejercicio2

        // Ejercicio 2: Debemos indicar si el mapa del ejercicio anterior corresponde a un número par o impar. 

        print("###### EJERCICIO 2 con IF ######");

        if (mapNumber % 2 == 0)
        {
            print("El mapa es par");
        }
        else
        {
            print("El mapa es impar");
        }

        print("###### EJERCICIO 2 con SWITCH ######");

        switch (mapNumber & 2)
        {
            case 0:
                print("El mapa es par");
                break;
            default:
                print("El mapa es impar");
                break;
        }

        #endregion

        #region ejercicio3

        /*
         Ejercicio 3: Dado un nombre, compararlo con la base de datos que tiene: “Juan”, “José”, “Javier” o “Julio”. 
        Si el nombre es cualquiera de los mencionados, mostrar por pantalla “Usted ingreso uno de los nombres de la lista:” y poner el nombre ingresado. 
        En caso de que el nombre ingresado no este en la lista decir: “Usted ingresó un nombre que no contemplamos”. 
         */

        print("###### EJERCICIO 3 con IF ######");

        if (inputName == "Juan")
        {
            print("Usted ingreso uno de los nombres de la lista: "+inputName);

        } else if (inputName == "José")
        {
            print("Usted ingreso uno de los nombres de la lista: " + inputName);
        }
        else if (inputName == "Javier")
        {
            print("Usted ingreso uno de los nombres de la lista: " + inputName);
        }
        else if (inputName == "Julio")
        {
            print("Usted ingreso uno de los nombres de la lista: " + inputName);

        } else
        {
            print("Usted ingresó un nombre que no contemplamos");
        }

        print("###### EJERCICIO 3 con SWITCH ######");

        switch (inputName)
        {
            case "Juan":
                print("Usted ingreso uno de los nombres de la lista: " + inputName);
                break;
            case "José":
                print("Usted ingreso uno de los nombres de la lista: " + inputName);
                break;
            case "Javier":
                print("Usted ingreso uno de los nombres de la lista: " + inputName);
                break;
            case "Julio":
                print("Usted ingreso uno de los nombres de la lista: " + inputName);
                break;
            default:
                print("Usted ingresó un nombre que no contemplamos");
                break;
        }

        #endregion

        #region ejercicio4

        //Ejercicio 4: Dada la nota de un examen que se califica del 1 al 10, indicar si aprobo, promociono o reprobo sabiendo que menos de 4 es reprobado, menos de 8 es aprobado y mas de 8 es promocionado.

        print("###### EJERCICIO 4 con IF ######");

        evalutationNote = Random.Range(1, 11);

        if (evalutationNote < 4)
        {
            print("Reprobado");

        }
        else if (evalutationNote < 8)
        {
            print("Aprobado");
        }
        else if (evalutationNote >= 8)
        {
            print("Promocionado");
        }

        print("###### EJERCICIO 4 con SWITCH ######");

        switch (evalutationNote)
        {
            case < 4:
                print("Reprobado");
                break;
            case < 8:
                print("Aprobado");
                break;
            case >= 8:
                print("Promocionado");
                break;
        }

        #endregion
    }
}
