using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpGrower : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;
    public bool startGrowing; 
    // Start is called before the first frame update
    private void Update()
    {
        if (startGrowing == true)
        {
            Grow();
        }
    }

    // Update is called once per frame
    public void StartGrowing()
    {
        startGrowing = true;
        t = 0;
    }
    public void Grow()
    {
        if (t < 1)
        {
            t += Time.deltaTime;
        }
        else
        {
            startGrowing = false;
        }
        transform.localScale = Vector3.one * maxSize * curve.Evaluate(t); 
    }
}


