using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PhysicsController))]
public class AutoMovement : Movement
{
    [SerializeField] private Vector3 _direction;

    // Update is called once per frame
    void Update()
    {
        SimpleMove(_direction * _speed);
    }
}
