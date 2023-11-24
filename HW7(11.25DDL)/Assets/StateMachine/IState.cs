using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IState
{
    // Start is called before the first frame update
    void Enter()
    {
        
    }

    // Update is called once per frame
    void Exit()
    {
        
    }

    void LogicUpdate()
    { 
    }

    void PhysicUpdate()
    { 
    }
}
