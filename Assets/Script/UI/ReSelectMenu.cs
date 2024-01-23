using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSelectMenu : MonoBehaviour
{
    [SerializeField] private GameObject SelectCharacter;
    //[SerializeField] private GameObject Information;

    private ChararcterType chararcterType;

    public void ReSelectChar(int index)
    {
        chararcterType = (ChararcterType)index;
        var Char = GameManager.Instance.charactList.Find(item => item.Chararctertype == chararcterType);

        GameManager.Instance.SetCharacter(chararcterType, GameManager.Instance.name, Char.CharSprite);
        SelectCharacter.SetActive(false);  //삭제로 변경?
    }
}
