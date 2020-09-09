using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ShipEvents : MonoBehaviour
{
    [SerializeField] private float _shipThrust;
    [SerializeField] private string _shipMoveTag;
    [SerializeField] private string _shipDampenTag;

    public static ShipEvents current;

    public event Action<string, Vector3> onActivateEngine;
    public event Action<string, Vector3> onActivateDampening;
    public event Action onShipDestruction;
    //public event Action<string, Vector3> onChangeDistance;

    private void Awake()
    {
        current = this;
    }

    public void ActivateEngine(Vector3 thrust_direction)
    {
        if (onActivateEngine != null)
        {
            onActivateEngine(_shipMoveTag, -(thrust_direction * _shipThrust));
        }
    }

    public void ActivateDampening(Vector3 dampen_direction)
    {
        if (onActivateDampening != null)
        {
            onActivateDampening(_shipDampenTag, dampen_direction);
        }
    }

    public void ShipDestruction()
    {
        if (onShipDestruction != null)
        {
            onShipDestruction();
        }
    }

    //public void ChangeDistance(Vector3 thrust_direction)
    //{
    //    if (onActivateEngine != null)
    //    {
    //        onChangeDistance(_shipMoveTag, -(thrust_direction * _shipThrust));
    //    }
    //}
}
