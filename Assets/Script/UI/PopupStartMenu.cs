using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{
    public Text playerName;
    [SerializeField] private InputField InputField;

    public void OnCleakJoin()
    {
        if(!(2 < InputField.text.Length && InputField.text.Length <10))
        {
            Debug.Log("???");
            return;
        }

        playerName.text = InputField.text;
        Destroy(gameObject);
    }
}
