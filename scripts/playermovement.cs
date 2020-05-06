


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class playermovement : MonoBehaviour { 
    public joystickmovement joystick;
    public float movementSpeed = 10;
    public float turningSpeed = 60;

    void Update()
    {
        float horizontal = joystick.Horizontal() * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);

        float vertical = joystick.Vertical() * movementSpeed * Time.deltaTime;
        transform.Translate(0, 0, -vertical);
    }
}