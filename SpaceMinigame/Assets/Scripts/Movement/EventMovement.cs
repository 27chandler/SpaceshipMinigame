using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class EventMovement : Movement
{
    [SerializeField] private string _eventTag;

    void Start()
    {
        ShipEvents.current.onActivateEngine += Accelerate;

        base.OnStart();
    }

    void OnDestroy()
    {
        ShipEvents.current.onActivateEngine -= Accelerate;
    }

    private void Accelerate(string tag, Vector3 direction)
    {
        if (tag == _eventTag)
        {
            PhysicsMove(direction);
        }
    }

    private void Move(string tag, Vector3 direction)
    {
        if (tag == _eventTag)
        {
            SimpleMove(direction);
        }
    }
}
