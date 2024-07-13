using UnityEngine;

public class Example : MonoBehaviour
{
    public int playerSpeed = 3;
    private ObjetoTargetController objetoTargetController;

    void Start()
    {
        objetoTargetController = GameObject.FindObjectOfType<ObjetoTargetController>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            objetoTargetController.ChangeColorBlue();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            objetoTargetController.ChangeColorRed();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            objetoTargetController.ChangeColorGreen();
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            objetoTargetController.ChangeColorWhite();
        }

    }
}

