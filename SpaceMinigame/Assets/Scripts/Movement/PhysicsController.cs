using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 _movementDelta;
    private Vector2 _velocity;
    private PhysicsController _physicsController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + _movementDelta + _velocity);
        _movementDelta = new Vector2(0.0f, 0.0f);
    }

    public Vector2 GetVelocity() { return _velocity; }
    public void SetVelocity(Vector2 velocity) { _velocity = velocity; }

    public void AddDelta(Vector2 delta)
    {
        _movementDelta += delta;
    }

    public void AddVelocity(Vector2 velocity)
    {
        _velocity += velocity;
    }
}
