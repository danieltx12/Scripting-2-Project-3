using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rpgSM : StateMachine
{
    [SerializeField] InputController _input;
    public InputController Input => _input;
    void Start()
    {
        
        ChangeState<SetupBattleState>();
    }

}
