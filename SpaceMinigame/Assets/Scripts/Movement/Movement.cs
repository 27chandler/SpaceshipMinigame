using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;

    public float SetSpeed() => _speed;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SimpleMove(Vector3 direction)
    {
        Vector3 directionNormalized = direction.normalized;
        transform.position += directionNormalized * _speed * Time.deltaTime;
    }

    public void PhysicsMove(Vector3 direction)
    {
        Vector3 directionNormalized = direction.normalized;
        rb.AddForce(direction * _speed * Time.deltaTime);
    }
}
