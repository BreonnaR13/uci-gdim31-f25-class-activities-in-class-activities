using System;
using JetBrains.Annotations;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField ]private Transform playerTransform;
    //already has the cat transform
    
    private void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed);
    }

    public bool disableChase()
    {
        enabled = false;
        return enabled;
    }

    public bool enableChase()
    {

        enabled = true;
        return enabled;
    }
}
