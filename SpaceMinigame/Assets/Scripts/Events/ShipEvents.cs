using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShipEvents : MonoBehaviour
{
    [SerializeField] private float _shipThrust;

    public static ShipEvents current;

    public event Action<Vector3> onActivateEngine;

    private void Awake()
    {
        current = this;
    }

    public void ActivateEngine(Vector3 thrust_direction)
    {
        if (onActivateEngine != null)
        {
            onActivateEngine(thrust_direction * _shipThrust);
        }
    }
}
