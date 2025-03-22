using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineGrower : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;

    // Start is called before the first frame update
    public void StartGrowing()
    {
        StartCoroutine (Grow());
    }

    // Update is called once per frame
    public IEnumerator Grow()
    {
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
            yield return null; 
        }
        }
        
}
