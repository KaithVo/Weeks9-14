using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Rings : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0.4f;
    public float t;
    private SpriteRenderer sr;


    void Start()
    {//have different image everytime mouse click
     //list
        sr = GetComponent<SpriteRenderer>();
    }
    // using Corounting
    public void StartGrowing()
    {
        StartCoroutine(Grow());
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
