using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Transform objectTransform;
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Transform basePosition;
    public bool inserted;
    

    private void Start()
    {
        objectTransform = GetComponent<Transform>();
    }

    public void InsertLight()
    {
        if (!inserted)
        {
            objectTransform.transform.position = targetTransform.position;
            Debug.Log("Light Inserted");
        }
    }

    public void ReturnLight()
    {
        if (inserted)
        {
            objectTransform.transform.position = basePosition.position;
            Debug.Log("light return occured");
        }
    }

    
}
