using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HandsTrigger : MonoBehaviour
{
    public TextMeshProUGUI score;
    public static int scoreCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ButtonArcade"))
        {
            scoreCount += 1;
        }
    }
    private void Update()
    {
        score.text = scoreCount.ToString();
    }
}
