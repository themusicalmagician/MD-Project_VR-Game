using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScene : MonoBehaviour
{
    public GameObject Jumpscare;
    public GameObject Chase;
    public AudioSource sound;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Spooky"))
        {
            Chase.SetActive(false);
            Jumpscare.SetActive(true);
            sound.PlayDelayed(0);
            StartCoroutine(Restart());
        }
        if (collision.gameObject.CompareTag("Door"))
        {
            SceneManager.LoadScene("Escaped");
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("VR Setup 3");
    }
}
