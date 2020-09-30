using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonChargeActivate : ButtonActivate
{
    [SerializeField] private int _maxCharges;
    [SerializeField] private int _charges;


    protected override void ActivateSecondaryEffects()
    {
        if (_charges > 0)
            _charges--;
        else
            _canThrust = false;

        base.ActivateSecondaryEffects();
    }
}
