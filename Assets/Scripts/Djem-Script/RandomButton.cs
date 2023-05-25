using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour
{
    [SerializeField] List<GameObject> buttons;
    public float colorChangeDuration = 5f;
    public float delayBetweenChanges = 5f;

    public static List<GameObject> currentButtons;

    private void Start()
    {
        currentButtons = new List<GameObject>();
        StartCoroutine(ChangeButtonColors());
    }

    public static void changeWhite()
    {
        foreach (GameObject button in currentButtons)
        {
            button.GetComponent<Renderer>().material.color = Color.white;
            button.GetComponent<Collider>().enabled = false;
        }
    }

    private IEnumerator ChangeButtonColors()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayBetweenChanges);

            // Change old buttons to white and disable their colliders
            foreach (GameObject button in currentButtons)
            {
                button.GetComponent<Renderer>().material.color = Color.white;
                button.GetComponent<Collider>().enabled = false;
            }

            // Clear the list of current buttons
            currentButtons.Clear();

            // Shuffle the buttons list
            List<GameObject> shuffledButtons = new List<GameObject>(buttons);
            int n = shuffledButtons.Count;
            while (n > 1)
            {
                n--;
                int k = Random.Range(0, n + 1);
                GameObject temp = shuffledButtons[k];
                shuffledButtons[k] = shuffledButtons[n];
                shuffledButtons[n] = temp;
            }

            // Get new random buttons
            for (int i = 0; i < 3; i++)
            {
                if (i < shuffledButtons.Count)
                {
                    GameObject randomButton = shuffledButtons[i];
                    currentButtons.Add(randomButton);

                    // Change the color of the new button to yellow and enable its collider
                    randomButton.GetComponent<Renderer>().material.color = Color.yellow;
                    randomButton.GetComponent<Collider>().enabled = true;
                }
            }

            yield return new WaitForSeconds(colorChangeDuration);

            // Change buttons back to white and disable their colliders
            foreach (GameObject button in currentButtons)
            {
                button.GetComponent<Renderer>().material.color = Color.white;
                button.GetComponent<Collider>().enabled = false;
            }
        }
    }
}
