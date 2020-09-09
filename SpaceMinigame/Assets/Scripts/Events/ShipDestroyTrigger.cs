using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipDestroyTrigger : MonoBehaviour
{
    [SerializeField] private string destroyTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == destroyTag)
        {
            ShipEvents.current.ShipDestruction();
        }
    }
}
