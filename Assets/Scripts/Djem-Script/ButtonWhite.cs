using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonWhite : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("hands"))
        {
            RandomButton.changeWhite();
        }
    }
}
