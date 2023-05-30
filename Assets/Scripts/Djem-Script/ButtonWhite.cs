using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonWhite : MonoBehaviour
{
    public AudioSource hit;
    public static bool point = false;
    Collider collision;
    public TextMeshProUGUI score;
    int scoreCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hands"))
        {
            hit.PlayDelayed(0);
            scoreCount += 1;
            Debug.Log(scoreCount);
            gameObject.GetComponent<Renderer>().material.color = Color.white;
            gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
