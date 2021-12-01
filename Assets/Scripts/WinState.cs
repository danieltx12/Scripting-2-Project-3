using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class WinState : State
{
    public static event Action WinStateBegan;

    public override void Enter()
    {
        Debug.Log("Win state: ...Enter");
        WinStateBegan?.Invoke();
    }

    public override void Exit()
    {
        Debug.Log("Win State: Exit...");
    }
}
