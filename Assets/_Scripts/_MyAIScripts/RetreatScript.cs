using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetreatScript : MonoBehaviour
{
    //This script is used by several scripts which act as state machines for different npc's in this game. This is the script that handles when an NPC such as a civilian, guard, or merchant sees the player.

    public Transform player;
    public Transform home;

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 10;
    public int jumpHeight = 1;
    public int count = 0;

    public bool closeToPlayer = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {       
        Retreat();
    }

    void Retreat()
    {
        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true.
        //If closeToPlayer is true, the character will move in the opposite direction of the player as if they are running away.

        float dist = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(dist);
        if (dist <= 100.0f)
        {
            closeToPlayer = true;
        }
        else
        {
            closeToPlayer = false;
        }
        if (closeToPlayer)
        {

            transform.position = Vector3.MoveTowards(transform.position,
            player.transform.position, Time.deltaTime * -runSpeed);
            Vector3 rotateTowardPlayer = new Vector3(-player.transform.position.x,
            transform.position.y, -player.transform.position.z);
            transform.LookAt(rotateTowardPlayer);          
        }

        playerAnims.SetBool("isRunningForward", true);
    }
}
