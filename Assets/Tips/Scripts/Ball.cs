using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float time;
    
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnEnable()
    {
        rb.AddForce(Vector3.up * force);
        Invoke(nameof(DisableObject),time);
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }
}
