using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro; 

public class Cups : MonoBehaviour
{

    private bool Secret = false;


    void Update()
    {
        int result = Random.Range(0, 10);

        if (result <= 1)
        {
            Secret = true;
        }
    }
}
