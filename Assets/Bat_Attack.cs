using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bat_Attack : MonoBehaviour
{
    public AnimationCurve curve;
    public float maxPosition = 2f;
    private Vector3 originalPosition;
    public Button button;


    public void Attack()
    {
        StartCoroutine(MoveCoroutine());
    }

    public IEnumerator MoveCoroutine()
    {
        float t = 0;
        //action happens before
        button.interactable = false; 
        while (t < 1)
        {
            t += Time.deltaTime;
            //action happens when corountine runs
            transform.position = Vector3.one * maxPosition * curve.Evaluate(t); 
            yield return null;
        }
        button.interactable = true;
    }
     
}
