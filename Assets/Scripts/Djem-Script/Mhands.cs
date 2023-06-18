using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mhands : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mhands"))
        {
            MoveF.speed = 0f;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mhands"))
        {
            MoveF.speed = 3f;
        }
    }
}
