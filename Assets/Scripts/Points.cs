using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Points : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    private int score = 0;
    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
    }
}
