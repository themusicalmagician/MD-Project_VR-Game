using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArms : MonoBehaviour
{
    public Vector3 D;
    void Update()
    {
        transform.Translate(D * Time.deltaTime * 2);
    }
}
