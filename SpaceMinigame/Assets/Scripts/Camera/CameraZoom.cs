using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private string zoomTag;
    void Start()
    {
        InteractionEvent.current.onPlayerEnterTrigger += Zoom;
        InteractionEvent.current.onPlayerExitTrigger += ExitZoom;
    }

    void OnDestroy()
    {
        InteractionEvent.current.onPlayerEnterTrigger -= Zoom;
        InteractionEvent.current.onPlayerExitTrigger -= ExitZoom;
    }

    private void Zoom(string tag)
    {
        Debug.Log("Triggered: " + tag);
        if (zoomTag == tag)
        {
            Camera.main.orthographicSize = 5.0f;
        }
    }

    private void ExitZoom(string tag)
    {
        if (zoomTag == tag)
        {
            Camera.main.orthographicSize = 25.0f;
        }
    }
}
