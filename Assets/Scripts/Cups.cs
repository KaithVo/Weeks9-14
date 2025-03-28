using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro; 

public class Cups : MonoBehaviour
{

    private bool Secret = false;
    public AnimationCurve curve;

    void Update()
    {
        int result = Random.Range(0, 10);

        if (result <= 1)
        {
            Secret = true;
        }
    }
    // text when player clicks
    public void DisplayAnimatedText(TextMeshPro text)
    {
      
        StartCoroutine(ShowText());
    }

    public IEnumerator ShowText(TextMeshProUGUI text)
    {
        float t = 0f;
        while (t < 0.4f)
        {
            t += Time.deltaTime;
            text.transform.localScale = Vector3.one * curve.Evaluate(t);
            yield return null;
        }

        t = 0f;
        while (t < 0.4f)
        {
            t += Time.deltaTime;
            text.transform.localScale = Vector3.one * curve.Evaluate(t);
            yield return null;
        }

        text.gameObject.SetActive(false);
    }
}
