using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ButtonArcade"))
        {
            Points.scoreCount += 1;
            Points.score.text = Points.scoreCount.ToString();
        }
    }
}
