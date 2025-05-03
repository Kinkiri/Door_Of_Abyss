using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBattleState
{
    BattleStateMachine Machine { get; set; }
    void EnterState();
    void ExitState();
    void UpdateState();
}
