using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    private AudioSource audioSource;

    public float speed = 2.0f; // Velocidad de movimiento del dragón
    public float movementRange = 5.0f; // Rango máximo de movimiento en la dirección Z

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

        // Reemplaza esto con la condición adecuada para cuando quieras que el dragón ruja
        if (Input.GetKeyDown(KeyCode.P))
        {
            Roar();
        }
    }

    private void MoveForwardBackward()
    {
        float newPositionZ = transform.position.z;

        // Mueve el dragón hacia adelante
        if (movingForward)
        {
            newPositionZ += speed * Time.deltaTime;

            // Cambia la dirección al alcanzar el límite delantero
            if (newPositionZ >= startPosition.z + movementRange)
            {
                movingForward = false;
            }
        }
        // Mueve el dragón hacia atrás
        else
        {
            newPositionZ -= speed * Time.deltaTime;

            // Cambia la dirección al alcanzar el límite trasero
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
