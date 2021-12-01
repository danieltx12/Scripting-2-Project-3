using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyTurnState : rpgGameState
{
    public static event Action EnemyTurnBegan;
    public static event Action EnemyTurnEnded;
    public PlayerStats playerStats;

    [SerializeField] float _pauseDuration = 1.5f;

    public override void Enter()
    {
        Debug.Log("Enemy Turn: ...Enter");
        EnemyTurnBegan?.Invoke();

        StartCoroutine(EnemyThinkingRoutine(_pauseDuration));
    }

    public override void Exit()
    {
        Debug.Log("Enemy Turn: Exit...");
    }

    IEnumerator EnemyThinkingRoutine(float pauseDuration)
    {
        Debug.Log("Enemy thinking...");
        yield return new WaitForSeconds(pauseDuration);
        Debug.Log("Perform Action");
        Debug.Log("Check if player HP is zero!");
        if (playerStats.HP <= 0)
        {
            EnemyTurnEnded?.Invoke();
            StateMachine.ChangeState<LoseState>();
        }
        else
        {
            Debug.Log("Player Alive! Attempt to enter Enemy State!");
            EnemyTurnEnded?.Invoke();
            StateMachine.ChangeState<PlayerTurnState>();
        }

        //turn over, back to player.

    }
}

