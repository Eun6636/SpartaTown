using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject ReSelectChar;
    //[SerializeField] private GameObject ReName;

    public void OnCleakReChar()
    {
        ReSelectChar.SetActive(true);
    }

    //public void OnCleakReName()
    //{
    //    ReName.SetActive(true);
    //}
}
