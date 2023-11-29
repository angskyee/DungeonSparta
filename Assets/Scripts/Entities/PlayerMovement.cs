using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Camera _camera;
    private int speed = 5; //speed 조절

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _camera = Camera.main;
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        ApllyMovement(_movementDirection);

    }

    private void LateUpdate()
    {
        UpdateCameraPosition(); // 메인 카메라 위치 업데이트

    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    private void ApllyMovement(Vector2 direction)
    {
        direction = direction * speed;
        _rigidbody.velocity = direction;
    }

    private void UpdateCameraPosition()
    {
        // 메인 카메라의 위치를 플레이어의 위치로 업데이트
        Vector3 playerPosition = transform.position;
        playerPosition.z = _camera.transform.position.z;
        _camera.transform.position = playerPosition;
    }
}
