using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleScript : MonoBehaviour
{
    //This script is used by several scripts which act as state machines for different npc's in this game. This is the script that handles when an NPC such as a civilian, guard, or merchant sees the player.

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count;
    public int directionToTurn;

    public bool closeToPlayer;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        Idle();
    }

    void Idle()
    {
        //The character's movespeed is set to 0 and the walking animation boolean is set to false so that the character does not continue to walk while no movement is happening.

        walkSpeed = 0;
        runSpeed = 0;

        playerAnims.SetBool("isWalkingForward", false);
    }
}
