using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonActivate : MonoBehaviour
{
    [SerializeField] private Vector3 _thrustDirection;
    // Start is called before the first frame update
    void Start()
    {
        InteractionEvent.current.onPlayerInteract += ActivateButton;
    }

    void OnDestroy()
    {
        InteractionEvent.current.onPlayerInteract -= ActivateButton;
    }

    private void ActivateButton(Vector3 position)
    {
        if (Vector3.Distance(position,transform.position) <= 1.0f)
            ShipEvents.current.ActivateEngine(_thrustDirection);
    }
}
