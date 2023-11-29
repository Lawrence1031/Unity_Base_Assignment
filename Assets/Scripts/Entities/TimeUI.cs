using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Time : MonoBehaviour
{
    public TextMeshProUGUI textMeshProText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (textMeshProText == null)
        {
            textMeshProText = GetComponent<TextMeshProUGUI>();
        }

        DateTime nowTime = DateTime.Now;
        string displayedTime = nowTime.ToString("MM-dd HH:mm");

        textMeshProText.text = displayedTime;
        
    }
}
