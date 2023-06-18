using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public float Timer;

    private void Start()
    {
        Destroy(gameObject, Timer);
    }
}
