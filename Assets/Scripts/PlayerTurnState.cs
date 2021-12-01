using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurnState : rpgGameState
{
    [SerializeField] Text _playerTurnTextUI = null;
    public EnemyStats enemyStats;
    public PlayerStats playerStats;

    int _playerTurnCount = 0;

    public override void Enter()
    {
            Debug.Log("Player Turn: ...Entering");
            _playerTurnTextUI.gameObject.SetActive(true);

            _playerTurnCount++;
            _playerTurnTextUI.text = "Player Turn: " + _playerTurnCount.ToString();

        StateMachine.Input.PressedConfirm += OnPressedConfirm;
    }

        public override void Exit()
    {
        _playerTurnTextUI.gameObject.SetActive(false);
        StateMachine.Input.PressedConfirm -= OnPressedConfirm;
        Debug.Log("Player Turn: Exiting...");
    }

    void OnPressedConfirm()
    {
        Debug.Log("Perform Action");
        Debug.Log("Check if enemy HP is zero!");
        if (enemyStats.HP <= 0)
        {
            StateMachine.ChangeState<WinState>();
        }
        else
        {
            Debug.Log("Enemy Alive! Attempt to enter Enemy State!");
            StateMachine.ChangeState<EnemyTurnState>();
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            enemyStats.HP = -10;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            playerStats.HP = -10;
        }
    }
}
