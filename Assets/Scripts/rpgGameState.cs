using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(rpgSM))]
public class rpgGameState : State
{
   protected rpgSM StateMachine { get; private set; }

     void Awake()
    {
        StateMachine = GetComponent<rpgSM>();
    }
}
