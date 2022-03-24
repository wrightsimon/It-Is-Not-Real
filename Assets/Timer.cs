using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI text;

    void Awake() 
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update() 
    {
        int timeInSeconds = (int)Time.time;
        text.text = timeInSeconds.ToString();
    }
}
