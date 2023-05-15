using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputEventBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _movement;
    [SerializeField]
    private ProjectileSpawnerBehaviour _projectileSpawner;

    // Start is called before the first frame update
    void Awake()
    {
        _movement = GetComponent<PlayerMovementBehaviour>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        _movement.MoveDirection = context.ReadValue<Vector2>();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        _projectileSpawner.Fire();
    }
}
