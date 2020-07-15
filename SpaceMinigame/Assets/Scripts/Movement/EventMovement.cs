using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMovement : Movement
{
    [SerializeField] private bool isRightActive = false;
    [SerializeField] private bool isLeftActive = false;

    private void Update()
    {
        if (isRightActive)
        {
            MoveRight();
            isRightActive = false;
        }

        if (isLeftActive)
        {
            MoveLeft();
            isLeftActive = false;
        }
    }

    private void MoveRight()
    {
        PhysicsMove(transform.right);
    }

    private void MoveLeft()
    {
        PhysicsMove(-transform.right);
    }
}
