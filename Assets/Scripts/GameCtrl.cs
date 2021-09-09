using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCtrl : MonoBehaviour
{
    public GameObject ClearText;
    public GameObject GameOverText;

    void Start()
    {
        
    }


    void Update()
    {
        int count   = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1  = GameObject.FindGameObjectsWithTag("Player").Length;

        if (count == 0)
        {
            ClearText.SetActive(true);
        }

        if (count1 == 0)
        {
            GameOverText.SetActive(true);
        }
    }
}
