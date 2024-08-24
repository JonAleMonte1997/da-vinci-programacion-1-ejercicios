using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week2Exercise2 : MonoBehaviour
{

    /*
    
    En un juego de cartas donde existen criaturas que tienen un determinado ataque, tenemos la situaci�n en la que dos de estos se ven enfrentados y se tiene que indicar lo siguiente: 
        a. Si el ataque de las dos es igual: 'Se destruyeron ambas criaturas.' 
        b. Si el ataque del primero es mayor al del segundo: 'El primero aniquilo al segundo.'
        c. Si el ataque del segundo es mayor al del primero: 'El segundo aniquilo al primero.'
    
    */

    public int mobOneAttack = 10;

    public int mobTwoAttack = 20;

    void Start()
    {
        if( mobOneAttack == mobTwoAttack)
        {
            print("Se destruyeron ambas criaturas.");

        } else if ( mobOneAttack > mobTwoAttack)
        {
            print("El primero aniquilo al segundo.");

        } else if(mobOneAttack < mobTwoAttack)
        {
            print("El segundo aniquilo al primero.");
        }
    }
}
