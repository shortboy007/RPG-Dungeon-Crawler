using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorfulState : State
{
    Transform destination;
    int count = 0;

    public ColorfulState(StateController stateController) : base(stateController) { }

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
        changeColor();
    }

void changeColor()
    {
            var colorToChange = Random.Range(0, 6);

            if (colorToChange == 0)
            {
                stateController.ChangeColor(Color.green);
            }
            else if (colorToChange == 1)
            {
                stateController.ChangeColor(Color.blue);
            }
            if (colorToChange == 2)
            {
                stateController.ChangeColor(Color.red);
            }
            else if (colorToChange == 3)
            {
                stateController.ChangeColor(Color.grey);
            }
            if (colorToChange == 4)
            {
                stateController.ChangeColor(Color.white);
            }
            else if (colorToChange == 5)
            {
                stateController.ChangeColor(Color.black);
            }      
    }

}
