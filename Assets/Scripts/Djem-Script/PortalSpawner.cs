using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    public GameObject Portal;
    float Y;

    void Start()
    {
        StartCoroutine(StartDelay());
    }

    IEnumerator PositionPortal()
    {
        float SpawnTime = (Random.Range(1.5f, 3));
        int rand = Random.Range(0, 2);
        if (rand == 0)
        {
            Y = -2.4f;
        }
        if (rand == 1)
        {
            Y = -2;
        }
        yield return new WaitForSeconds(SpawnTime);
        transform.localPosition = new Vector3(-1, Y, 0);
        GameObject instantiatedObject = Instantiate(Portal, transform.position, Quaternion.identity);
        StartCoroutine(PositionPortal());
    }
    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(4);
        StartCoroutine(PositionPortal());
    }
}
