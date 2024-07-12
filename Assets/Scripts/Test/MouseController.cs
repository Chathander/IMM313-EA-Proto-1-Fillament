using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;


public class MouseController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject _mouseGameObject;
    public InputAction mouseControls;
    public Camera camera;
    void Start()
    {
        
    }

    private void OnEnable()
    {
        mouseControls.Enable();
    }

    private void OnDisable()
    {
        mouseControls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        MousePositionBehavior();
    }

    private void MousePositionBehavior()
    {
        //I want to get the position of the mouse.x and mouse.y and apply it to the gameobject in the scene... hmmm.

        _mouseGameObject.transform.position = camera.ScreenToViewportPoint(mouseControls.ReadValue<Vector2>());


    }
}
