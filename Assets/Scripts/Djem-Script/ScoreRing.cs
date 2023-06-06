using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreRing : MonoBehaviour
{
    public ParticleSystem ScoreParticle;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Yeethings"))
        {
            ScoreParticle.Play();
            Points.scoreCount += Points.points;
            Points.score.text = Points.scoreCount.ToString();
        }
    }
}
