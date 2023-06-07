using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedButton : MonoBehaviour
{
    public int PointsToGet;
    public bool ButtonRoom;
    public bool YeetRoom;
    public ParticleSystem Press;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("hands"))
        {
            Press.Play();
            if(ScoreRing.scoreCount != PointsToGet && YeetRoom == true)
            {
                Spooky.jumpscare = true;
                ScoreRing.scoreCount = 0;
            }
            else if(ScoreRing.scoreCount == PointsToGet && YeetRoom == true)
            {
                SceneManager.LoadScene("VR Setup");
                HandsTrigger.scoreCount = 0;
            }

            if (HandsTrigger.scoreCount != PointsToGet && ButtonRoom == true)
            {
                Spooky.jumpscare = true;
                HandsTrigger.scoreCount = 0;
            }
            else if (HandsTrigger.scoreCount == PointsToGet && ButtonRoom == true)
            {
                SceneManager.LoadScene("VR Setup 2");
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
