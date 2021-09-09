using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackCtrl : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
