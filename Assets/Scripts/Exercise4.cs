using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise4 : MonoBehaviour
{
    private int correctNum;
    private int incorrectNum;

    public TextMeshProUGUI correctText;
    public TextMeshProUGUI incorrectText;

    private int turnCounter = 10;
    private int xNum;
    private int randomNum;
    public GameObject[] randomGuess;


    public void Turns()
    {
        if(turnCounter > 0)
        {
            randomGuess[randomNum].SetActive(false);
            turnCounter--;
            //StartCoroutine(Options());
        }
    }
    
   /* private IEnumerator Options()
    {
        randomNum = Random.Range(0, 2);
        randomGuess[randomNum].SetActive(true);

        if (randomNum == xNum)
        {
            correctNum++;
        }
        else
        {
            incorrectNum--;
        }
        if (turnCounter == 0)
        {
            randomGuess[randomNum].SetActive(false);
            correctText.gameObject.SetActive(true);
            correctText.gameObject.SetActive(false);
            correctText.text = "Correct answers:" + correctNum;
            incorrectText.text = "Incorrect answers:" + incorrectNum;
        }
    } */
}
