using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : State
{
    Transform wanderObject;

    public WanderState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {

        

    }
public override void Act()
    {
        if (wanderObject != null)
        {
            stateController.ai.SetTarget(wanderObject);
        }
    }

    public override void OnStateEnter()
    {
        wanderObject = GameObject.FindWithTag("WanderObject").transform;
        //stateController.ChangeColor(Color.red);
    }

}
