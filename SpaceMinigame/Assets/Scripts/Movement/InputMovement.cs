using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class InputMovement : Movement
{


    [SerializeField] private string _horizontalAxis;
    [SerializeField] private string _verticalAxis;


    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3();
        movement.x = Input.GetAxisRaw(_horizontalAxis);
        movement.y = Input.GetAxisRaw(_verticalAxis);

        SimpleMove(movement);
    }
}
