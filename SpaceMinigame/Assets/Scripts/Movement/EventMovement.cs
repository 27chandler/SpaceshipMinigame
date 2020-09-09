using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class EventMovement : Movement
{
    [SerializeField] private string _moveTag;
    [SerializeField] private string _blockTag = "ShipDampen";

    void Start()
    {
        ShipEvents.current.onActivateEngine += Accelerate;
        ShipEvents.current.onActivateDampening += Block;

        base.OnStart();
    }

    void OnDestroy()
    {
        ShipEvents.current.onActivateEngine -= Accelerate;
        ShipEvents.current.onActivateDampening -= Block;
    }

    private void Accelerate(string tag, Vector3 direction)
    {
        if (tag == _moveTag)
        {
            PhysicsMove(direction);
        }
    }

    private void Move(string tag, Vector3 direction)
    {
        if (tag == _moveTag)
        {
            SimpleMove(direction);
        }
    }

    private void Block(string tag, Vector3 direction)
    {
        if (tag == _blockTag)
        {
            DampenDirection(direction);
        }
    }
}
