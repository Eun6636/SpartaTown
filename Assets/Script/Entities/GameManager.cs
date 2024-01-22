using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ChararcterType
{
    Penfuin,
    BearJelly
}

public class Character
{
    public ChararcterType chararcterType;
    public Transform transform;
    public Sprite sprite;
    public RuntimeAnimatorController Animator;
}

//public class GameManager : MonoBehaviour
//{
//    [SerializeField] private Transform

//}
