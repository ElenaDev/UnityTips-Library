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
        //Pongo el texto en la UI y lo hago "invisible"
        textUI.text = textToShow;
        textUI.maxVisibleCharacters = 0;
        //Por cada letra que hay en el texto:
        foreach (char c in textToShow)
        {
            //vamos haciendo visible letra a letra
            textUI.maxVisibleCharacters++;
            //"Esperamos" un tiempo "time" para volver al foreach
            yield return new WaitForSeconds(time);
        }
    }
}
