using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class EventMovement : Movement
{
    void Start()
    {
        ShipEvents.current.onActivateEngine += Move;

        base.OnStart();
    }

    void OnDestroy()
    {
        ShipEvents.current.onActivateEngine -= Move;
    }

    private void Move(Vector3 direction)
    {
        PhysicsMove(direction);
    }
}
