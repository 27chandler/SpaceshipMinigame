using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    [SerializeField] protected Vector3 _thrustDirection;
    [SerializeField] protected bool _canThrust = true;
    // Start is called before the first frame update
    void Start()
    {
        InteractionEvent.current.onPlayerInteract += ActivateButton;
    }

    void OnDestroy()
    {
        InteractionEvent.current.onPlayerInteract -= ActivateButton;
    }

    protected void ActivateButton(Vector3 position)
    {
        if ((Vector3.Distance(position,transform.position) <= 1.0f) && (_canThrust))
        {
            ShipEvents.current.ActivateEngine(_thrustDirection);
            ActivateSecondaryEffects();
        }
    }

    protected virtual void ActivateSecondaryEffects()
    {

    }
}
