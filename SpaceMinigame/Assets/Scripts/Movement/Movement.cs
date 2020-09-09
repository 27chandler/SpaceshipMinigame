using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public abstract class Movement : MonoBehaviour
{
    [SerializeField] protected float _speed;

    public float SetSpeed() => _speed;

    private PhysicsController _physicsController;

    private void Start()
    {
        OnStart();
    }

    public void SimpleMove(Vector3 direction)
    {
        Vector3 directionNormalized = direction.normalized;

        Vector2 newDelta;
        newDelta.x = directionNormalized.x * _speed * Time.deltaTime;
        newDelta.y = directionNormalized.y * _speed * Time.deltaTime;
        _physicsController.AddDelta(newDelta);
    }

    public void PhysicsMove(Vector3 velocity)
    {
        _physicsController.AddVelocity(new Vector2(velocity.x, velocity.y) * Time.deltaTime);
    }

    public void DampenDirection(Vector3 velocity)
    {
        _physicsController.SetBlockDirection(velocity);
    }

    protected void OnStart()
    {
        _physicsController = GetComponent<PhysicsController>();
    }
}
