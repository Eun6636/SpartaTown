using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupStartMenu : MonoBehaviour
{

    [SerializeField] private Image CharacterSprite;
    [SerializeField] private InputField InputField;
    [SerializeField] private GameObject Information;
    [SerializeField] private GameObject SelectCharacter;

    private ChararcterType chararcterType;

    public void OncleakCharacter()
    {
        Information.SetActive(false);
        SelectCharacter.SetActive(true);
    }

    public void OnCleakSelectCharecter(int index)
    {
        chararcterType = (ChararcterType)index;
        var Char = GameManager.Instance.charactList.Find(item =>item.Chararctertype == chararcterType);
        CharacterSprite.sprite = Char.CharSprite;
        CharacterSprite.SetNativeSize();

        SelectCharacter.SetActive(false);
        Information.SetActive(true);


    }

    public void OnCleakJoin()
    {
        if(!(2 < InputField.text.Length && InputField.text.Length <10))
        {
            return;
        }
        GameManager.Instance.SetCharacter(chararcterType, InputField.text, CharacterSprite.sprite);
        Destroy(gameObject);
    }
}
