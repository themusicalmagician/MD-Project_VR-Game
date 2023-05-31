using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetItems : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Respawn"))
        {
            transform.localPosition = new Vector3(Random.Range(-15, -10), -0.8f, -39.8f);
        }
        if (collider.gameObject.CompareTag("Score"))
        {
            transform.localPosition = new Vector3(Random.Range(-15, -10), -0.8f, -39.8f);
        }
    }
}
