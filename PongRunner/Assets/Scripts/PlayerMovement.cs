using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /**this class is responsible for allowing the player to use the W&D keys to move
     * left and right respectively, as well as use the left and right mouse buttons
     * to rotate the paddle in the corresponding direction.**/
    public CharacterController controller;

    public float speed = 12f;
    public bool buttonDown = false;
    public int paddleRotationPosition = 0;

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
