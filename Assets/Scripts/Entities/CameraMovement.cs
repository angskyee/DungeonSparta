using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Camera _camera;
    private TopDownCharacterController _controller;

    private void Awake()
    {
        _camera = Camera.main;
        _controller = GetComponent<TopDownCharacterController>();

    }

    private void LateUpdate()
    {
        Vector3 characterDirection = _controller.transform.position;
        characterDirection.z = _camera.transform.position.z;
        _camera.transform.position = characterDirection;
        
    }

}
