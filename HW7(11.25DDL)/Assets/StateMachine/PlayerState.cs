using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerState : ScriptableObject, IState
{
    // Start is called before the first frame update
   protected Animator animator;
    protected PlayerStateMachine stateMachine;

    public  virtual void Initialize(Animator animator, PlayerStateMachine stateMachine)
    {
        this.animator = animator;
        this.stateMachine = stateMachine;
    }
    public virtual void Enter()
    { 
    }

    // Update is called once per frame
    public virtual void Exit()
    {

    }

    public virtual void LogicUpdate()
    {
    }

    public virtual void PhysicUpdate()
    {

    }
}
