using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipLimitTrigger : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private Vector3 _dampenDirection;
    [SerializeField] private LayerMask _layer;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (_layer == (_layer | (1 << collision.gameObject.layer)))
            ShipEvents.current.ActivateDampening(_dampenDirection);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (_layer == (_layer | (1 << collision.gameObject.layer)))
            ShipEvents.current.ActivateDampening(new Vector3(0.0f,0.0f));
    }
}
