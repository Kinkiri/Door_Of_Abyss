using UnityEngine;

public class BattleStateMachine : MonoBehaviour
{
    private IBattleState currentState;
    public int currentRound = 0;
    public bool isPlayer1Turn = true;
    public bool isGameOver = false ;

    // 
    private BattleStartState battleStartState;
    private StartState startState;
    private SetupState setupState;
    private ActionState actionState;
    private CombatState combatState;
    private EndState endState;

    void Start()
    {
        InitializeStates();
        currentState = battleStartState;
        currentState.EnterState();
    }

    void Update()
    {
        if (!isGameOver)
            currentState.UpdateState();
    }

    void InitializeStates()
    {
        battleStartState = new BattleStartState(this);
        startState = new StartState(this);
        setupState = new SetupState(this);
        actionState = new ActionState(this);
        combatState = new CombatState(this);
        endState = new EndState(this);
    }

    public void SwitchState(IBattleState newState)
    {
        currentState.ExitState();
        currentState = newState;
        currentState.EnterState();
    }
}
