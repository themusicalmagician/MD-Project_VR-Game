using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public int PointsToGet;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("hands"))
        {
            if(Points.scoreCount > PointsToGet)
            {
                StartCoroutine(Spooky.Jumpscare());
            }
        }
    }
}
