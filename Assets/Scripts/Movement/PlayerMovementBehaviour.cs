using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    [SerializeField]
    private float _moveSpeed = 1;
    private Vector3 _moveDirection;

    public Vector3 MoveDirection { get => _moveDirection; set => _moveDirection = value; }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        _velocity = MoveDirection * _moveSpeed * Time.deltaTime;

        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
