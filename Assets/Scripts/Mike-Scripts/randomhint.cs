using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class randomhint : MonoBehaviour
{
    public TMP_Text hintNote;
    public static int randomNum;

    public void Start()
    {
        int X = (Random.Range(-2, 2));
        int Z = (Random.Range(1, 2));
        transform.position = new Vector3(X, 2, Z);

        randomNum = Random.Range(5, 40);
        hintNote.text = randomNum.ToString();
    }
}
