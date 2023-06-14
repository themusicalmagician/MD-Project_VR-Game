using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveF : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 2);
    }
}
