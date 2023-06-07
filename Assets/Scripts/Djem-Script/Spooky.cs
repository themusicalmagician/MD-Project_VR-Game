using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Spooky : MonoBehaviour
{
    float Duration1;
    float Duration2;
    public GameObject Monster;
    public static bool jumpscare;

    [SerializeField]
    private static Volume volume;

    public Color newColor;
    public Color oldColor;

    public AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
    }

    private void Update()
    {
        sound.volume = 4;
        if (jumpscare == true)
        {
            StartCoroutine(Jumpscare());
            jumpscare = false;
        }
    }

    public static void ChangeBloomTint(Color color)
    {
        Bloom bloom;
        if (volume.profile.TryGet(out bloom))
        {
            bloom.tint.value = color;
        }
    }

    IEnumerator Jumpscare()
    {
        Duration1 = Random.Range(1f, 10f);
        Duration2 = Random.Range(0.1f, 0.8f);
        yield return new WaitForSeconds(Duration1);
        Monster.SetActive(true);
        sound.PlayDelayed(0);
        ChangeBloomTint(newColor);
        yield return new WaitForSeconds(Duration2);
        Monster.SetActive(false);
        ChangeBloomTint(oldColor);       
    }
}
