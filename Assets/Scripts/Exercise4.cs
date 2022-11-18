using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise4 : MonoBehaviour
{
    //Two options: 0 or 1
    public int options;
    //The correct one
    private int guess;

    public TextMeshProUGUI correct;
    public TextMeshProUGUI incorrect;
    public GameObject result;
    //We count the results and the turns
    private int turn;
    private int counter;


    void Start()
    {
        //We hide the results chart
        result.SetActive(false);
    }

    public void Answer()
    { 
        options = Random.Range(0, 2);
    }

    public void AnswerCount()
    {
        //If our answer and the correct answer are the same, we add 1 to the counter
        if (guess == options)
        {
            counter++;
        }
        //We repeat this until turn 10
        if (turn < 10)
        {
            turn++;
            Answer();
        }
        //On turn 10...
        if (turn == 10)
        {
            //...we show the results chart
            result.SetActive(true);
            correct.text = counter.ToString();
            incorrect.text = (10 - counter).ToString();
            Time.timeScale = 0;
        }
    }
}
