using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] private float _spawnInterval;
    [SerializeField] private float _spawnRange;
    [SerializeField] private GameObject _spawnObject;
    private PhysicsController _physics;

    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        _physics = GetComponent<PhysicsController>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > _spawnInterval)
        {
            GameObject new_asteroid = Instantiate(_spawnObject, transform.position + (Vector3.right * Random.Range(-_spawnRange, _spawnRange)), new Quaternion());
            PhysicsController new_physics_controller = new_asteroid.GetComponent<PhysicsController>();

            new_physics_controller.SetVelocity(_physics.GetVelocity());

            timer = 0.0f;
        }
    }
}
