using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoseState : State
{
    public static event Action LoseStateBegan;

    public override void Enter()
    {
        Debug.Log("Lose state: ...Enter");
        LoseStateBegan?.Invoke();
    }

    public override void Exit()
    {
        Debug.Log("Lose State: Exit...");
    }
}
