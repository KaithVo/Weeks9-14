using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Events;

public class DingDong : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(Rotation());
    }

    public IEnumerator Rotation()
    {
       
    float t = 0;
        //action happens before
      
        while (t < 1)
        {
            t += Time.deltaTime;
            //rotation so it will have to use Quaternion to rotate it 
            transform.rotation = new Quaternion(0, 0, -360 * t, 0);
            yield return null;
        }
        
    }


}
