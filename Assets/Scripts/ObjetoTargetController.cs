using UnityEngine;

public class ObjetoTargetController : MonoBehaviour
{
    Renderer renderer;

    // Variables para movimiento
    public float speed = 1.0f;
    public float distance = 5.0f;
    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool movingRight = true;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        startPosition = transform.position;
        endPosition = startPosition + new Vector3(distance, 0, 0);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (movingRight)
        {
            transform.position = Vector3.Lerp(transform.position, endPosition, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, endPosition) < 0.1f)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, speed * Time.deltaTime);
            if (Vector3.Distance(transform.position, startPosition) < 0.1f)
            {
                movingRight = true;
            }
        }
    }

    public void ChangeColorBlue()
    {
        // Cambiar el color del objeto a azul
        renderer.material.color = Color.blue;
    }

    public void ChangeColorRed()
    {
        // Cambiar el color del objeto a rojo
        renderer.material.color = Color.red;
    }

    public void ChangeColorGreen()
    {
        // Cambiar el color del objeto a verde
        renderer.material.color = Color.green;
    }

    public void ChangeColorWhite()
    {
        // Cambiar el color del objeto a blanco
        renderer.material.color = Color.white;
    }
}
