using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRing : MonoBehaviour
{
    public TextMeshProUGUI score;
    int scoreCount = 0;
    public int Points;
    public ParticleSystem ScoreParticle;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Yeethings"))
        {
            ScoreParticle.Play();
            scoreCount += Points;
            score.text = scoreCount.ToString();
        }
    }
}
