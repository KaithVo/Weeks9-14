using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    public RectTransform broccoli;
    public UnityEvent OntimerHasFinsh;
    public float timeLength = 3;
    public float t;
    // Start is called before the first frame update

    void Update()
    {
        t += Time.deltaTime;
        if(t > timeLength)
        {
            OntimerHasFinsh.Invoke();
            t = 0;
        }
    }
    public void MouseOnImage()
    {
        Debug.Log(" Mouse entered the image!");
        broccoli.localScale = Vector3.one * 1.2f;

    }

    // Update is called once per frame
    public void  MouseLeftImage()
    {
        Debug.Log("Mouse left the image!");
        broccoli.localScale = Vector3.one;

    }
}
