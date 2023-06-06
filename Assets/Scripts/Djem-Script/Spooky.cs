using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Spooky : MonoBehaviour
{
    static float Duration;
    public static GameObject Monster;

    [SerializeField]
    private static Volume volume;

    public static Color newColor;
    public static Color oldColor;

    public static AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
    }

    public static void ChangeBloomTint(Color color)
    {
        Bloom bloom;
        if (volume.profile.TryGet(out bloom))
        {
            bloom.tint.value = color;
        }
    }

    public static IEnumerator Jumpscare()
    {
        Duration = Random.Range(0.1f, 0.8f);
        Monster.SetActive(true);
        sound.PlayDelayed(0);
        ChangeBloomTint(newColor);
        yield return new WaitForSeconds(Duration);
        Monster.SetActive(false);
        ChangeBloomTint(oldColor);
    }
}
