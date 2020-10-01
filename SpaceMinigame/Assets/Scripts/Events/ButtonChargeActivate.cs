using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChargeActivate : ButtonActivate
{
    [SerializeField] private int _maxCharges;
    [SerializeField] private int _charges;
    [Space]
    [SerializeField] private float _sustainTime;

    private float _sustainTimer = 0.0f;
    private bool _isSustained = false;


    protected override void ActivateSecondaryEffects()
    {
        if (_isSustained)
            return;

        if (_charges > 0)
        {
            _charges--;
            _isSustained = true;
            _sustainTimer = _sustainTime;
        }
        else
        {
            _canThrust = false;
        }

        base.ActivateSecondaryEffects();
    }

    private void FixedUpdate()
    {
        if (!_isSustained)
            return;

        _sustainTimer -= Time.deltaTime;

        ShipEvents.current.ActivateEngine(_thrustDirection);

        if (_sustainTimer < 0.0f)
            _isSustained = false;
    }
}
