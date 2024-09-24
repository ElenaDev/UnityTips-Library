using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriter : MonoBehaviour
{
    [SerializeField] private string textToShow;
    [SerializeField] private TextMeshProUGUI textUI;
    [SerializeField] private float time;
    void Start()
    {
        StartCoroutine(nameof(ShowText));
    }
    IEnumerator ShowText()
    {
        //Limpio el texto de la interfaz
        textUI.text = "";
        //Por cada letra que hay en el texto:
        foreach (char c in textToShow)
        {
            //añado la letra al texto de la interfaz
            textUI.text += c;
            //"Esperamos" un tiempo "time" para volver al foreach
            yield return new WaitForSeconds(time);
        }
    }
}
