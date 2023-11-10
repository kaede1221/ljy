using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Run", fileName = "PlayerState_run")]
public class PlayerState_run : PlayerState
{


    public override void LogicUpdate()
    {
        if (!((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A))))
        {
            stateMachine.SwitchState(stateMachine.idleState);
  
            Debug.Log("idle");

        }
    }
}
