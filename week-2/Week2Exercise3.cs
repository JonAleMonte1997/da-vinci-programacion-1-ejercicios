using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Exercise3 : MonoBehaviour
{
    /*
    Estamos desarrollando un juego que tiene un sistema de log interno y necesitamos comprobar si el nombre de usuario ingresado es igual al de la base de datos. 
    En caso de serlo indicar <�Hola� mas su nombre de usuario>. Caso contrario indicar �El nombre de usuario no es correcto.� 
    */

    public string userNameStored = "Jonathan";

    public string userNameInserted = "Jonathan";

    void Start()
    {
        if (userNameInserted == userNameStored)
        {
            print("Hola " + userNameStored + ".");
        }
        else
        {
            print("El nombre de usuario no es correcto.");
        }
    }
}
