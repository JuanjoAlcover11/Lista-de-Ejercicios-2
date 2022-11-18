using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exercise2 : MonoBehaviour
{
    public Image bar;
    public float maxTime;
    private float time;

    void Start()
    {
        bar = GetComponent<Image>();
        //We set the start time at the max time
        time = maxTime;
    }

    void Update()
    {
        //Until the time gets to 0, it will decrease
        if(time > 0)
        {
            time -= Time.deltaTime;
            bar.fillAmount = time / maxTime;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
}
