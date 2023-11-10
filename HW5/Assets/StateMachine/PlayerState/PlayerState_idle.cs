using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/StateMachine/PlayerState/Idle",fileName = "PlayerState_idle")]



public class PlayerState_idle : PlayerState
{


    public override void LogicUpdate()
    {
        if ((Input.GetKey(KeyCode.D)) || (Input.GetKey(KeyCode.A)))
        {
            stateMachine.SwitchState(stateMachine.runState);
            Debug.Log("run");
        }
    }

}
