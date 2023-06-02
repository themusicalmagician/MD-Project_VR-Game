using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Spooky : MonoBehaviour
{
    int SpawnShowMonster;
    float Duration;
    public GameObject Monster;
    public int minTimer = 5;
    public int maxTimer = 60;

    [SerializeField]
    private Volume volume;

    public Color newColor;
    public Color oldColor;

    // Start is called before the first frame update
    void Start()
    {
        volume = GetComponent<Volume>();
        RandomValue();
    }

    public void ChangeBloomTint(Color color)
    {
        Bloom bloom;
        if (volume.profile.TryGet(out bloom))
        {
            bloom.tint.value = color;
        }
    }

    void RandomValue()
    {
        SpawnShowMonster = Random.Range(minTimer, maxTimer);
        Duration = Random.Range(0.1f, 0.8f);
        StartCoroutine(Jumpscare());
    }

    IEnumerator Jumpscare()
    {
        yield return new WaitForSeconds(SpawnShowMonster);
        Monster.SetActive(true);
        ChangeBloomTint(newColor);
        yield return new WaitForSeconds(Duration);
        Monster.SetActive(false);
        ChangeBloomTint(oldColor);
        RandomValue();
    }
}
