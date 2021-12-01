using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rpgUIController : MonoBehaviour
{
    [SerializeField] Text _enemyThinkingTextUI = null;
    [SerializeField] Text _playerHPtxt = null;
    [SerializeField] Text _enemyHPtxt = null;
    [SerializeField] GameObject _winTextUI = null;
    [SerializeField] GameObject _loseTextUI = null;
    [SerializeField] GameObject _menuReturnUI = null;
    public PlayerStats playerStats;
    public EnemyStats enemyStats;
    private int playerHP;
    private int enemyHP;

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
        WinState.WinStateBegan -= OnWinStateBegan;
        LoseState.LoseStateBegan -= OnLoseStateBegan;
    }

    private void Start()
    {
        _enemyThinkingTextUI.gameObject.SetActive(false);
        _menuReturnUI.gameObject.SetActive(false);
        _loseTextUI.gameObject.SetActive(false);
       _winTextUI.gameObject.SetActive(false);
        
       
    }

    private void Update()
    {
        enemyHP = enemyStats.HP;
        _enemyHPtxt.text = "Enemy HP: " + enemyHP.ToString();
        playerHP = playerStats.HP;
        _playerHPtxt.text = "Player HP: " + playerHP.ToString();
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

