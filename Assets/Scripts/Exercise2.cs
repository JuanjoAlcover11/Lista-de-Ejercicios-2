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
        time = maxTime;
    }

    void Update()
    {
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
