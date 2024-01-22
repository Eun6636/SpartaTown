using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected CharacterController controller;

    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        //controller = GetComponent<CharacterController>();
    }

    void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > .5f);
    }
}
