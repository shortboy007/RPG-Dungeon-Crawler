using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICounterCallFunction : MonoBehaviour
{
    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;
    public int directionToTurn;

    void Start()
    {

    }

    void Update()
    {
        count++;

        if (count == 100)
        {
            directionToTurn = Random.Range(0, 4);
            Wander();
        }
    }
    void Wander()
    {
        count = 0;
        walkSpeed = 10;
        runSpeed = 20;
    }
}
