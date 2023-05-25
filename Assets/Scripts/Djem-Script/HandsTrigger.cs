using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsTrigger : MonoBehaviour
{
    public AudioSource hit;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ButtonArcade"))
        {
            hit.PlayDelayed(0);
        }
    }
}
