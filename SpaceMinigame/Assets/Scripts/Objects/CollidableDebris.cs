using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CollidableDebris : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ShipEvents.current.ActivateEngine(Vector3.down);
        Destroy(gameObject);
    }
}
