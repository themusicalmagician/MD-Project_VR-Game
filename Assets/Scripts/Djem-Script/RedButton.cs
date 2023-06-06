using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public int PointsToGet;
    public bool ButtonRoom;
    public bool YeetRoom;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("hands"))
        {
            if(ScoreRing.scoreCount != PointsToGet && YeetRoom == true)
            {
                Spooky.jumpscare = true;
                ScoreRing.scoreCount = 0;
            }
            if (HandsTrigger.scoreCount != PointsToGet && ButtonRoom == true)
            {
                Spooky.jumpscare = true;
                HandsTrigger.scoreCount = 0;
            }
        }
    }
    private void Update()
    {
        if (YeetRoom == true && ButtonRoom == true || YeetRoom == false && ButtonRoom == false)
        {
            Debug.LogError("Select only one level!");
        }
    }
}
