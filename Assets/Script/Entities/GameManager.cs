using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ChararcterType
{
    Penfuin ,
    BearJelly
}


[System.Serializable]
public class Character
{
    public ChararcterType Chararctertype;
    public Sprite CharSprite;
    public RuntimeAnimatorController Animator;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Animator PlayerAnimator;
    public Text playerName;
    public SpriteRenderer Playersprite;
    public Transform playerTransform;

    public List<Character> charactList = new List<Character>();

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void SetCharacter(ChararcterType Type, string name,Sprite sprite)
    {
        var Char = GameManager.Instance.charactList.Find(item => item.Chararctertype == Type);

        if (Char.Chararctertype == ChararcterType.BearJelly)
        {
            playerTransform.position = new Vector3(playerTransform.position.x,
                playerTransform.position.y- 1.6f, 0);
        }

        PlayerAnimator.runtimeAnimatorController = Char.Animator;
        Playersprite.sprite = sprite;
        playerName.text = name;
    }

}
