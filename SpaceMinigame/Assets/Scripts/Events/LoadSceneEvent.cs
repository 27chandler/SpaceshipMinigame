using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneEvent : MonoBehaviour
{
    [SerializeField] private string name;

    void Start()
    {
        ShipEvents.current.onShipDestruction += LoadScene;
    }

    void OnDestroy()
    {
        ShipEvents.current.onShipDestruction -= LoadScene;
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(name);
    }
}
