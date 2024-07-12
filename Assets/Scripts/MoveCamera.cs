using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Transform targetTransform;

    private void Start()
    {
        _camera = Component.FindObjectOfType<Camera>();
    }

    public void Teleport()
    {
        _camera.transform.position = targetTransform.position;
    }
}
