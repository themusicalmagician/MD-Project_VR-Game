using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpookyMovement : MonoBehaviour
{
    float speed = 3f;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
