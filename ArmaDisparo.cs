using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaDisparo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(miCamara.transform.position, miCamara.transform.forward, out hit,Rango))
            {
                Debug.Log("en el blanco");
                Enemigo e = hit.transform.GetComponent<Enemigo>();
                if(e!=null)
                {
                    e.dañoEnemigo(DañoCausado);
                }
            }
            else
            {
                Debug.Log("en el blancon´t");
            }
        }
    }

    public int DañoCausado = 1; 

    public float Rango = 150f;

    public Camera miCamara;
}
