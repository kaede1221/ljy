using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerStateMachine : StateMachine
{
    public PlayerState_idle idleState;
    public PlayerState_run runState;
   [SerializeField] PlayerState[] states;
        Animator animator;
    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        stateTable = new Dictionary<System.Type, IState>(states.Length);

        foreach (PlayerState state in states)
        {
            state.Initialize(animator, this);
            stateTable.Add(state. GetType(), state);
        }

    }

    private void Start()
    {
        SwitchOn(stateTable[typeof(PlayerState_idle)]);
    }

}
