using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedButton : MonoBehaviour
{
    public bool ButtonRoom;
    public bool YeetRoom;
    public ParticleSystem Press;
    public AudioSource sound;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("hands"))
        {
            Press.Play();
            sound.PlayDelayed(0);
            if (ScoreRing.scoreCount != randomhint.randomNum && YeetRoom == true)
            {
                Spooky.jumpscare = true;
                ScoreRing.scoreCount = 0;
            }
            else if(ScoreRing.scoreCount == randomhint.randomNum && YeetRoom == true)
            {
                StartCoroutine(Scene3());
                HandsTrigger.scoreCount = 0;
            }

            if (HandsTrigger.scoreCount != randomhint.randomNum && ButtonRoom == true)
            {
                Spooky.jumpscare = true;
                HandsTrigger.scoreCount = 0;
            }
            else if (HandsTrigger.scoreCount == randomhint.randomNum && ButtonRoom == true)
            {
                StartCoroutine(Scene2());
                HandsTrigger.scoreCount = 0;
            }
        }
    }
    IEnumerator Scene2()
    {
        yield return new WaitForSeconds (5f);
        SceneManager.LoadScene("VR Setup 2");
    }
    IEnumerator Scene3()
    {
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
