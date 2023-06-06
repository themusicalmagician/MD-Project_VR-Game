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
            if(ScoreRing.scoreCount != PointsToGet)
            {
                Spooky.jumpscare = true;
                ScoreRing.scoreCount = 0;
            }
            if (HandsTrigger.scoreCount != PointsToGet)
            {
                Spooky.jumpscare = true;
                HandsTrigger.scoreCount = 0;    
            }
        }
    }
}
