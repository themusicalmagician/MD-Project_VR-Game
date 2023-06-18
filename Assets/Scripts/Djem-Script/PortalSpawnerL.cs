using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawnerL : MonoBehaviour
{
    public GameObject Portal;
    float Y;
    public static bool isRunning = true;
    public ParticleSystem wallP;

    void Start()
    {
        StartCoroutine(StartDelay());
    }

    IEnumerator PositionPortal()
    {
        isRunning = true;

        float SpawnTime = (Random.Range(1.5f, 3));
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            Y = -0.5f;
        }
        if (rand == 1)
        {
            Y = 0;
        }
        yield return new WaitForSeconds(SpawnTime);
        if(isRunning == true)
        {
            PortalSpawnerR.isRunning = false;
            transform.localPosition = new Vector3(-3, Y, 0);
            wallP.Play();
            GameObject instantiatedObject = Instantiate(Portal, transform.position, Quaternion.identity);
        }
        isRunning = true;
        StartCoroutine(PositionPortal());
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(4);
        StartCoroutine(PositionPortal());
    }

}
