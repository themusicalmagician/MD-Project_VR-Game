using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class randomhint : MonoBehaviour
{
    public TMP_Text hintNote;

    public void Start()
    {
        int X = (Random.Range(-2, 2));
        int Z = (Random.Range(1, 5));
        transform.position = new Vector3(X, 1, Z);

        int randomNum = Random.Range(20, 50);
        hintNote.text = randomNum.ToString();
    }
}
