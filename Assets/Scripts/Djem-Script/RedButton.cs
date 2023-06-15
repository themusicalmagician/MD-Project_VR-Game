using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedButton : MonoBehaviour
{
    public bool ButtonRoom;
    public bool YeetRoom;
    public ParticleSystem Press;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("hands"))
        {
            Press.Play();
            if(ScoreRing.scoreCount != randomhint.randomNum && YeetRoom == true)
            {
                Spooky.jumpscare = true;
                ScoreRing.scoreCount = 0;
            }
            else if(ScoreRing.scoreCount == randomhint.randomNum && YeetRoom == true)
            {
                StartCoroutine(Scene3());
            }

            if (HandsTrigger.scoreCount != randomhint.randomNum && ButtonRoom == true)
            {
                Spooky.jumpscare = true;
                HandsTrigger.scoreCount = 0;
            }
            else if (HandsTrigger.scoreCount == randomhint.randomNum && ButtonRoom == true)
            {
                StartCoroutine(Scene2());
            }
        }
    }
    IEnumerator Scene2()
    {
        HandsTrigger.scoreCount = 0;
        yield return new WaitForSeconds (5f);
        SceneManager.LoadScene("VR Setup 2");
    }
    IEnumerator Scene3()
    {
        HandsTrigger.scoreCount = 0;
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("VR Setup 3");
    }

    private void Update()
    {
        if (YeetRoom == true && ButtonRoom == true || YeetRoom == false && ButtonRoom == false)
        {
            Debug.LogError("Select only one level!");
        }
    }
}
