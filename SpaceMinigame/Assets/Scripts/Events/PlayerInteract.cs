using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private KeyCode _interactKey;

    void Update()
    {
        if (Input.GetKey(_interactKey))
            InteractionEvent.current.PlayerInteract(transform.position);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InteractionEvent.current.PlayerEnterTrigger(other.tag);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        InteractionEvent.current.PlayerExitTrigger(other.tag);
    }
}
