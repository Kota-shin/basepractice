using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCtrl : MonoBehaviour
{
    [Header("初速の速さ")] public float speed;

    void Start()
    {
        Rigidbody rb = this.GetComponent<Rigidbody>();

        Vector3 force = new Vector3(10.0f, 10.0f, 0.0f) * speed;

        rb.AddForce(force);

    }


    void Update()
    {
        
    }
}
