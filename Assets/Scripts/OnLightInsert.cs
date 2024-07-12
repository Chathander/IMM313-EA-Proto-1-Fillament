using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class OnLightInsert : MonoBehaviour
{
    [SerializeField] private Skybox _skybox;
    [Space] 
    [SerializeField] private Material baseMaterial;
    [SerializeField] private Material happyMaterial;
    [SerializeField] private Material madMaterial;
    [SerializeField] private Material sadMaterial;
    [Header("Given Light Objects")]
    [SerializeField] private MoveObject lightObject1;
    [SerializeField] private MoveObject lightObject2;
    [SerializeField] private MoveObject lightObject3;

    private void Awake()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        lightObject2.inserted = true;
        lightObject1.inserted = true;
        lightObject3.inserted = true;

        if (other.CompareTag("HappyLight"))
        {
            _skybox.material = happyMaterial;
        }
        else if (other.CompareTag("SadLight"))
        {
            _skybox.material = sadMaterial;
        }
        else if (other.CompareTag("MadLight"))
        {
            _skybox.material = madMaterial;
        }
        else
        {
            return;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        lightObject2.inserted = false;
        lightObject1.inserted = false;
        lightObject3.inserted = false;
        //Debug.Log("lights can be inserted");
        _skybox.material = baseMaterial;
    }

    private void skyboxChange()
    {
        
    }
}
