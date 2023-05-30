using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandsTrigger : MonoBehaviour
{
    public TextMeshProUGUI score;
    int scoreCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ButtonArcade"))
        {
            scoreCount += 1;
            score.text = scoreCount.ToString();
            Debug.Log(scoreCount);
        }
    }
}
