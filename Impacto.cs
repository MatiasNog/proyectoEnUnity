using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public int VidaEnemigo = 3;

    public void da�oEnemigo(int o)
    {
        VidaEnemigo -= o;

        if(VidaEnemigo == 0) 
        {
            Destroy(gameObject);
        }

    }
}
