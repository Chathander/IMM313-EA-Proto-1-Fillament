using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetHov : MonoBehaviour
{

    [SerializeField] private bool isHovered;
    [SerializeField] private UnityEvent _event;

    private void OnMouseEnter()
    {
        isHovered = true;
    }

    private void OnMouseExit()
    {
        isHovered = false;
    }

    private void OnMouseDown()
    {
        if (isHovered == true)
        {
            _event.Invoke();
        }
    }
}
