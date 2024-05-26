using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public static bool Running = false;
    public static void SetStateMachine() => SetStateMachine(Running);
    
    // Private
    private static Animator animator;
    private static readonly int BRunning = Animator.StringToHash("bRunning");

    private void OnEnable()
    {
        animator = this.GetComponent<Animator>();
    }
    
    private static void SetStateMachine(bool state)
    {
        animator.SetBool(BRunning, state);
    }
}
