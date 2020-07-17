using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public static InteractionEvent current;

    public event Action<Vector3> onPlayerInteract;
    public event Action<string> onPlayerEnterTrigger;
    public event Action<string> onPlayerExitTrigger;

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

    public void PlayerEnterTrigger(string tag)
    {
        if (onPlayerEnterTrigger != null)
        {
            onPlayerEnterTrigger(tag);
        }
    }

    public void PlayerExitTrigger(string tag)
    {
        if (onPlayerExitTrigger != null)
        {
            onPlayerExitTrigger(tag);
        }
    }
}
