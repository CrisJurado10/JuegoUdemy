using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    private AudioSource audioSource;

    public float speed = 2.0f; // Velocidad de movimiento del drag�n
    public float movementRange = 5.0f; // Rango m�ximo de movimiento en la direcci�n Z

    private Vector3 startPosition;
    private bool movingForward = true;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        startPosition = transform.position;
    }

    void Update()
    {
        MoveForwardBackward();

        // Reemplaza esto con la condici�n adecuada para cuando quieras que el drag�n ruja
        if (Input.GetKeyDown(KeyCode.P))
        {
            Roar();
        }
    }

    private void MoveForwardBackward()
    {
        float newPositionZ = transform.position.z;

        // Mueve el drag�n hacia adelante
        if (movingForward)
        {
            newPositionZ += speed * Time.deltaTime;

            // Cambia la direcci�n al alcanzar el l�mite delantero
            if (newPositionZ >= startPosition.z + movementRange)
            {
                movingForward = false;
            }
        }
        // Mueve el drag�n hacia atr�s
        else
        {
            newPositionZ -= speed * Time.deltaTime;

            // Cambia la direcci�n al alcanzar el l�mite trasero
            if (newPositionZ <= startPosition.z - movementRange)
            {
                movingForward = true;
            }
        }

        transform.position = new Vector3(transform.position.x, transform.position.y, newPositionZ);
    }

    public void Roar()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
