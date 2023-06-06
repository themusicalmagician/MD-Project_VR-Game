using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRing : MonoBehaviour
{
    public ParticleSystem ScoreParticle;
    public TextMeshProUGUI score;
    public static int scoreCount = 0;
    public int points;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Yeethings"))
        {
            ScoreParticle.Play();
            scoreCount += points;
        }
    }
    private void Update()
    {
        score.text = scoreCount.ToString();
    }
}
