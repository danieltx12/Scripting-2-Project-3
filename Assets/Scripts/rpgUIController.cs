using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rpgUIController : MonoBehaviour
{
    [SerializeField] Text _enemyThinkingTextUI = null;
    [SerializeField] GameObject _winTextUI = null;
    [SerializeField] GameObject _loseTextUI = null;
    [SerializeField] GameObject _menuReturnUI = null;

    private void OnEnable()
    {
        EnemyTurnState.EnemyTurnBegan += OnEnemyTurnBegan;
        EnemyTurnState.EnemyTurnEnded += OnEnemyTurnEnded;
        WinState.WinStateBegan += OnWinStateBegan;
        LoseState.LoseStateBegan += OnLoseStateBegan;
    }

    private void OnDisable()
    {
        EnemyTurnState.EnemyTurnBegan -= OnEnemyTurnBegan;
        EnemyTurnState.EnemyTurnEnded -= OnEnemyTurnEnded;
    }

    private void Start()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }

    void OnEnemyTurnBegan()
    {
        _enemyThinkingTextUI.gameObject.SetActive(true);
    }

    void OnEnemyTurnEnded()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
    }

    void OnWinStateBegan()
    {
        _menuReturnUI.gameObject.SetActive(true);
        _winTextUI.gameObject.SetActive(true);
    }

    void OnLoseStateBegan()
    {
        _menuReturnUI.gameObject.SetActive(true);
        _loseTextUI.gameObject.SetActive(true);
    }
}

