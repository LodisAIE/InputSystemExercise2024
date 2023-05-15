using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputDelegateBehaviour : MonoBehaviour
{
    private PlayerControls _playerControls;
    private PlayerMovementBehaviour _movement;

    [SerializeField]
    private ProjectileSpawnerBehaviour _projectileSpawner;

    // Start is called before the first frame update
    void Awake()
    {
        _playerControls = new PlayerControls();    

        _movement = GetComponent<PlayerMovementBehaviour>();
        _playerControls.Ship.Move.performed += (context) => { _movement.MoveDirection = context.ReadValue<Vector2>(); };
        _playerControls.Ship.Fire.performed += (context) => { _projectileSpawner.Fire(); };
    }

    private void OnEnable()
    {
        _playerControls.Enable();   
    }

    private void OnDisable()
    {
        _playerControls.Disable();
    }
}
