using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipLimitTrigger : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private Vector3 _dampenDirection;

    private void OnTriggerStay2D(Collider2D collision)
    {
        ShipEvents.current.ActivateDampening(_dampenDirection);
        Debug.Log("Dampening activated");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        ShipEvents.current.ActivateDampening(new Vector3(0.0f,0.0f));
        Debug.Log("Dampening deactivated");
    }
}
