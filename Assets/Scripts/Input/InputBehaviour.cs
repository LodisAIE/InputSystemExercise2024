using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBehaviour : MonoBehaviour
{
    [SerializeField]
    private ProjectileSpawnerBehaviour _projectileSpawner;
    private PlayerMovementBehaviour _movement;

    private void Awake()
    {
        _movement = GetComponent<PlayerMovementBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        _movement.MoveDirection = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        if (Input.GetButtonDown("Fire1"))
            _projectileSpawner.Fire();
    }
}
