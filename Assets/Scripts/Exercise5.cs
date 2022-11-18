using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Exercise5 : MonoBehaviour
{
    private int yearNum;
    private int animal;
    public TMP_InputField yearText;
    public Image image;
    public Sprite[] images;
    public TextMeshProUGUI animalText;
    public string[] animalsText;

    void Update()
    {//We divide the year number by the 12 horoscopes
        yearNum = int.Parse(yearText.text);
        animal = yearNum % 12;
        //The animal image and text shows up
        image.sprite = images[animal];
        animalText.text = animalsText[animal];
    }
}
