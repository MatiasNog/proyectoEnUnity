using System.Collections;
using System.Collections.Generic;
using UnityEditor.UI;
using UnityEngine;

public class MovimientoJugador1 : MonoBehaviour
{
    public CharacterController control;

    public float velocidad = 12f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ejeX = Input.GetAxis("Horizontal");
        float ejeZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * ejeX + transform.forward * ejeZ;

        control.Move(move * velocidad * Time.deltaTime);
    }
}
