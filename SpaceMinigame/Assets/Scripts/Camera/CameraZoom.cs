using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] private string zoomTag;

    private bool _isZoomed = true;

    void Start()
    {
        InteractionEvent.current.onPlayerActivateZoom += Zoom;
        InteractionEvent.current.onPlayerDeactivateZoom += ExitZoom;
        InteractionEvent.current.onPlayerToggleZoom += ToggleZoom;
    }

    void OnDestroy()
    {
        InteractionEvent.current.onPlayerActivateZoom -= Zoom;
        InteractionEvent.current.onPlayerDeactivateZoom -= ExitZoom;
        InteractionEvent.current.onPlayerToggleZoom -= ToggleZoom;
    }

    private void Zoom(string tag)
    {
        if (zoomTag == tag)
        {
            SetZoom(5.0f, true);
        }
    }

    private void ExitZoom(string tag)
    {
        if (zoomTag == tag)
        {
            SetZoom(25.0f, false);
        }
    }

    private void ToggleZoom()
    {
        _isZoomed = !_isZoomed;

        if (_isZoomed)
        {
            SetZoom(5.0f, _isZoomed);
        }
        else
        {
            SetZoom(25.0f, _isZoomed);
        }

    }

    private void SetZoom(float zoom, bool mode)
    {
        Camera.main.orthographicSize = zoom;
        _isZoomed = mode;
    }
}
