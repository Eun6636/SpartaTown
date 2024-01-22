using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;


    void Awake()
    {
        _controller = GetComponent<CharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate() 
    {
        ApplyMovment(_movementDirection);

    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }



    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 10; //만약 스테이터스가 생기면 여기 수정 (SSS)

        _rigidbody.velocity = direction;
    }
}
