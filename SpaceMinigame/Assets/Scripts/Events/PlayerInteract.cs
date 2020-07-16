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
}
