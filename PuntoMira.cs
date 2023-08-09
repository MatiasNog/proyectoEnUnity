using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntoMira : MonoBehaviour
{
    public float Sensitivity = 100f;
    public Transform Jugador1;
    public float Rotacion = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        Rotacion = Rotacion - mouseY;
        Rotacion = Mathf.Clamp(Rotacion, -90f, 90f);

        transform.localRotation = Quaternion.Euler(Rotacion, 0f, 0f);

        Jugador1.Rotate(Vector3.up * mouseX);
    }
}
