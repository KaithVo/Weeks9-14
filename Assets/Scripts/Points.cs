using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score = 0;
    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
