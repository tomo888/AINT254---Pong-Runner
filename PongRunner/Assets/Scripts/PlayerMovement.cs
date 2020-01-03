using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public bool buttonDown = false;
    public int paddleRotationPosition = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Vector3 move = Vector3.right * x;
        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetMouseButtonDown(0) && buttonDown == false && paddleRotationPosition != -1)
        {
            transform.Rotate(0, -45, 0);
            buttonDown = true;
            paddleRotationPosition -= 1;
        }

        else if (Input.GetMouseButtonDown(1) && buttonDown == false && paddleRotationPosition != 1)
        {
            transform.Rotate(0, 45, 0);
            buttonDown = true;
            paddleRotationPosition += 1;
        }

        else
        {
            transform.Rotate(0, 0, 0);
            buttonDown = false;
        }

    }
}
