using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataTimeController : MonoBehaviour
{
    [SerializeField] private Text dateTimeText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dateTimeText.text = GetCurrentDate();
    }

    public string GetCurrentDate()
    {
        return DateTime.Now.ToString("HH : mm");
    }
}
