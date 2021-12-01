using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    [SerializeField] public int HP = 100;
    [SerializeField] public int ATK = 100;
    [SerializeField] public int MAG = 100;
    [SerializeField] public int DEF = 100;
    [SerializeField] public int CRIT = 10;
    [SerializeField] public bool ElecWeak = false;
    [SerializeField] public bool FireWeak = false;
    [SerializeField] public bool IceWeak = false;
}
