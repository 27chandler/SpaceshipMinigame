using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class InteractionEvent : MonoBehaviour
{
    public static InteractionEvent current;

    public event Action<Vector3> onPlayerInteract;
    public event Action<string> onPlayerActivateZoom;
    public event Action<string> onPlayerDeactivateZoom;
    public event Action onPlayerToggleZoom;

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

    public void PlayerActivateZoom(string tag)
    {
        if (onPlayerActivateZoom != null)
        {
            onPlayerActivateZoom(tag);
        }
    }

    public void PlayerDeactivateZoom(string tag)
    {
        if (onPlayerDeactivateZoom != null)
        {
            onPlayerDeactivateZoom(tag);
        }
    }

    public void PlayerToggleZoom()
    {
        if (onPlayerToggleZoom != null)
        {
            onPlayerToggleZoom();
        }
    }
}
