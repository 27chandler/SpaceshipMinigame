using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public static InteractionEvent current;

    public event Action<Vector3> onPlayerInteract;
    
    private void Awake()
    {
        current = this;
    }

    public void PlayerInteract(Vector3 position)
    {
        if (onPlayerInteract != null)
        {
            onPlayerInteract(position);
        }
    }
}
