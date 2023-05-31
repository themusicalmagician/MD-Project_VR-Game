using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YeetItems : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Respawn"))
        {
            transform.position = new Vector3(Random.Range(-4, 4), 1.63f, 3.2f);
            Debug.Log("help");
        }
    }
}
