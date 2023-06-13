using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpawner : MonoBehaviour
{
    public GameObject Portal;

    void Start()
    {
        StartCoroutine(PositionPortal());
    }

    IEnumerator PositionPortal()
    {
        float SpawnTime = (Random.Range(1.5f, 4));
        float Z = (Random.Range(0.4f, -0.4f));       
        float Y = (Random.Range(-0.4f, 0.2f));
        yield return new WaitForSeconds(SpawnTime);
        transform.localPosition = new Vector3(-1, Y, Z);
        GameObject instantiatedObject = Instantiate(Portal, transform.position, Quaternion.identity);
        StartCoroutine(PositionPortal());
    }
}
