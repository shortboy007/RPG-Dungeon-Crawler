using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : State
{
    Transform player;
    Transform destination;

    public ChaseState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {

        

    }
public override void Act()
    {
        if (player != null)
        {
            stateController.ai.SetTarget(player);
        }
    }

    public override void OnStateEnter()
    {
        player = GameObject.FindWithTag("Player").transform;
        //stateController.ChangeColor(Color.red);
        stateController.checkPlayerDistance();
    }

}
