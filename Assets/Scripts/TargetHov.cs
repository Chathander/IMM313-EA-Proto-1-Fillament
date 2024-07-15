using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TargetHov : MonoBehaviour
{
/// <summary>
/// This is the main interactor for our prototype. Takes the OnMouse... native events to create a point and click
/// like experience.
/// </summary>
    [SerializeField] private bool isHovered;
    [SerializeField] private UnityEvent _event;
    [SerializeField] private GameObject highlightObject;
    //[SerializeField] private ParticleSystem _emotionParticleSystem;

    private void Start()
    {
        
    }

    private void OnMouseEnter()
    {
        //_emotionParticleSystem.Play();
        isHovered = true;
        highlightObject.SetActive(true);
    }

    private void OnMouseExit()
    {
        isHovered = false;
        highlightObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        if (isHovered == true)
        {
            _event.Invoke();
        }
    }
}
