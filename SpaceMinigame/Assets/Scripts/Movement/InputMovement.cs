using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class InputMovement : Movement
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            SimpleMove(transform.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            SimpleMove(-transform.up);
        }
        if (Input.GetKey(KeyCode.D))
        {
            SimpleMove(transform.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            SimpleMove(-transform.right);
        }
    }
}
