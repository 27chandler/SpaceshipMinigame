using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsController : MonoBehaviour
{
    private Vector2 _movementDelta;
    private Vector2 _velocity;
    private Vector3 _blockDirection;

    private PhysicsController _physicsController;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (CheckBlocking(_blockDirection))
        {
            if (_blockDirection.x != 0.0f)
            {
                _velocity.x = 0.0f;
            }
            else if (_blockDirection.y != 0.0f)
            {
                _velocity.y = 0.0f;
            }
        }

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

    public void SetBlockDirection(Vector3 direction)
    {
        _blockDirection = direction;
    }

    public bool CheckBlocking(Vector3 direction)
    {
        if ((direction.x > 0.0f) && (_velocity.x > 0.0f))
        {
            return true;
        }
        else if ((direction.x < 0.0f) && (_velocity.x < 0.0f))
        {
            return true;
        }

        if ((direction.y > 0.0f) && (_velocity.y > 0.0f))
        {
            return true;
        }
        else if ((direction.y < 0.0f) && (_velocity.y < 0.0f))
        {
            return true;
        }

        return false;
    }
}
