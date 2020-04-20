using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    //This script is used by several scripts which act as state machines for different npc's in this game. This is the script that handles when a guard or enemy becomes hostile tp the player.

    public Transform player;

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;

    public bool isAttacking;
    public bool closeToPlayer;
    public bool awayFromPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        Attack();
    }

    void Attack()
    {
        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true.

        float distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
        //Debug.Log("Player" + distToPlayer);
        if (distToPlayer <= 10)
        {
            closeToPlayer = true;
        }
        else
        {
            closeToPlayer = false;
        }

        if (distToPlayer >= 10.0f)
        {
            awayFromPlayer = true;
        }
        else
        {
            awayFromPlayer = false;
        }

        //If the character is not close to the player, but attack mode is active, they will move and rotate towards the player.

        if (awayFromPlayer)
        {
            walkSpeed = 5;
            runSpeed = 20;
            transform.position = Vector3.MoveTowards(transform.position,
            player.transform.position, Time.deltaTime * walkSpeed);
            Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
            transform.position.y, player.transform.position.z);
            transform.LookAt(rotateTowardPlayer);

            playerAnims.SetBool("isRunningForward", true);
            playerAnims.SetBool("isAttackingBlunt", false);
        }

        //If the character is close to the player, his movement speed becomes 0 and a bool is activated which begins an attack animation.

        if (closeToPlayer)
        {
            walkSpeed = 0;
            runSpeed = 0;
            Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
            transform.position.y, player.transform.position.z);
            transform.LookAt(rotateTowardPlayer);
            playerAnims.SetBool("isAttackingBlunt", true);
            //playerAnims.SetBool("isWalkingForward", false);
            playerAnims.SetBool("isRunningForward", false);
        }
    }
}
