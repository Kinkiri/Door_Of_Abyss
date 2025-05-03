using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 
/// </summary>
public class BattleStartState : IBattleState
{
    public BattleStateMachine Machine { get; set; }

    public void EnterState()
    {
        
    }
    public void ExitState()
    {
        
    }
    public void UpdateState()
    {
        
    }

    public BattleStartState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}
/// <summary>
/// 
/// </summary>
public class StartState : IBattleState
{
    public BattleStateMachine Machine { get; set; }
    public void EnterState()
    {

    }
    public void ExitState()
    {

    }
    public void UpdateState()
    {

    }
    public StartState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}
/// <summary>
/// 
/// </summary>
public class SetupState : IBattleState
{
    public BattleStateMachine Machine { get; set; }
    public void EnterState()
    {

    }
    public void ExitState()
    {

    }
    public void UpdateState()
    {

    }
    public SetupState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}
/// <summary>
/// 
/// </summary>
public class ActionState : IBattleState
{
    public BattleStateMachine Machine { get; set; }
    public void EnterState()
    {

    }
    public void ExitState()
    {

    }
    public void UpdateState()
    {

    }
    public ActionState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}
/// <summary>
/// 
/// </summary>
public class CombatState : IBattleState
{
    public BattleStateMachine Machine { get; set; }
    public void EnterState()
    {

    }
    public void ExitState()
    {

    }
    public void UpdateState()
    {

    }
    public CombatState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}
/// <summary>
/// 
/// </summary>
public class EndState : IBattleState
{
    public BattleStateMachine Machine { get; set; }
    public void EnterState()
    {

    }
    public void ExitState()
    {

    }
    public void UpdateState()
    {

    }
    public EndState(BattleStateMachine machine)
    {
        this.Machine = machine;
    }
}