﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupBattleState : rpgGameState
{
    [SerializeField] int _startingCardNumber = 10;
    [SerializeField] int _numberOfPlayers = 2;

    bool _activated = false;

    public override void Enter()
    {
        Debug.Log("Setup: ...Entering");
        Debug.Log("Creating " + _numberOfPlayers + " players.");
        Debug.Log("Creating deck with " + _startingCardNumber + " cards.");

        _activated = false;
    }

    public override void Tick()
    {
        if(_activated == false)
        {
            _activated = true;
            StateMachine.ChangeState<PlayerTurnState>();
        }
    }

    public override void Exit()
    {
        _activated = false;
        Debug.Log("Setup: Exiting");
    }
}
