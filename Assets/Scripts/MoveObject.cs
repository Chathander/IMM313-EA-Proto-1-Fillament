using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private Transform objectTransform;
    [SerializeField] private Transform targetTransform;
    [SerializeField] private Transform basePosition;
    [SerializeField] private bool inserted;

    private void Start()
    {
        objectTransform = GetComponent<Transform>();
    }

    public void InsertLight()
    {
        if (!inserted)
        {
            objectTransform.transform.position = targetTransform.position;
            inserted = true;
        }
    }

    public void ReturnLight()
    {
        if (inserted)
        {
            objectTransform.transform.position = basePosition.position;
            inserted = false;
        }
    }
}
