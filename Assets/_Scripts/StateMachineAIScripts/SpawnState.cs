using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnState : State
{
    Transform destination;


    public SpawnState(StateController stateController) : base(stateController) { }

    public override void CheckTransitions()
    {

    }
public override void Act()
    {
        if (destination == null || stateController.ai.DestinationReached())
        {
            destination = stateController.GetNextNavPoint();
            stateController.ai.SetTarget(destination);
        }
    }

    public override void OnStateEnter()
    {
        destination = stateController.GetNextNavPoint();
        stateController.ChangeColor(Color.yellow);
        //stateController.spawnAIMan();
    }

}
