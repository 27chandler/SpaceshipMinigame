using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private KeyCode _interactKey;
    [SerializeField] private KeyCode _zoomKey;

    void Update()
    {
        if (Input.GetKey(_interactKey))
            InteractionEvent.current.PlayerInteract(transform.position);

        if (Input.GetKeyDown(_zoomKey))
            InteractionEvent.current.PlayerToggleZoom();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        InteractionEvent.current.PlayerDeactivateZoom(other.tag);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        InteractionEvent.current.PlayerActivateZoom(other.tag);
    }
}
