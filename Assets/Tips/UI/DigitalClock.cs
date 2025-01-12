using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DigitalClock : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textUI;

    private void Update()
    {
        CalculateAndDisplayTime();       
    }
    private void CalculateAndDisplayTime()
    {
        DateTime time = DateTime.Now;
        string hour = LeadingZero(time.Hour);
        string minute = LeadingZero(time.Minute);
        string second = LeadingZero(time.Second);
        //Mostramos en la interfaz:
        textUI.text = hour + ":" + minute + ":" + second;
    }
    //A partir de un int, devuelve un string del número dado
    //añadiendo ceros a la izquierda si el valor es menor a 10
    private string LeadingZero(int n)
    {
        return n.ToString().PadLeft(2, '0');
    }
}

