using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonWhite : MonoBehaviour
{
    public AudioSource hit;
    public static bool point = false;
    Collider collision;
    public ParticleSystem ScoreParticle;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hands"))
        {
            hit.PlayDelayed(0);
            ScoreParticle.Play();
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
