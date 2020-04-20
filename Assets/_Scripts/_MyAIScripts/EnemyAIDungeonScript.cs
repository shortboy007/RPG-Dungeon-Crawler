using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIDungeonScript : MonoBehaviour
{
    //This script acts as a self-contained state machine for the enemy characters in this game. It uses booleans to determine what actions the characters could take when certain conditions are met.

    public Transform player;

    /*public Transform wanderObjectForward;
    public Transform wanderObjectRight;
    public Transform wanderObjectLeft;
    */

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;
    public int directionToTurn;

    public bool closeToPlayer = false;
    public bool withinAttackDistance = false;
    public bool safeDistance = false;
    public bool idleState = false;
    public bool wanderState = false;
    public bool patrolState = false;
    public bool chaseState = false;
    public bool attackState = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        //The enemy characters start the game in the idle state.

        idleState = true;
    }

    // Update is called once per frame
    void Update()
    {
        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true. Otherwise, safeDistance is true;
        //If the player is close enough to the player, they are withinAttackDistance.

        //Debug.Log(count);

        float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log("Player" + distToPlayer);
        if (distToPlayer <= 7)
        {
            closeToPlayer = true;
            safeDistance = false;
        }
        else
        {
            closeToPlayer = false;
            safeDistance = true;
        }

        if(distToPlayer <= 5)
        {
            withinAttackDistance = true;
        }
        else
        {
            withinAttackDistance = false;
        }

        if (closeToPlayer)
        {
            ChaseState();
        }
        else if (withinAttackDistance)
        {
            AttackState();
        }
        else if(safeDistance)
        {
            IdleState();
            //stateTimer();
        }

    }

    //This stateTimer method adds to the count variable every frame and when it gets to 100, the character's behavior shifts from the idle state to the wander state. 
    //The count variable is then set to 0 and starts again.

    //void stateTimer()
    //{
    //    count++;

    //    if (count == 100 && wanderState)
    //    {

    //        IdleState();
    //        idleState = true;
    //        wanderState = false;
    //    }
    //    else if (count == 100 && idleState)
    //    {
            
    //        WanderState();
    //        idleState = false;
    //        wanderState = true;
    //    }
    //}

    //The character does not move in this state and an idle animation plays if there is one.

    void IdleState()
    {
        count = 0;
        walkSpeed = 0;
        runSpeed = 0;
        //transform.rotation = wanderObjectForward.transform.rotation;
        count++;

        playerAnims.SetBool("isWalkingForward", false);
        playerAnims.SetBool("isRunningForward", false);

        //Debug.Log("IdleState");
    }

    //The character follows or chases the player when they come within a certain distance.

    void ChaseState()
    {
        count = 0;
        walkSpeed = 5;
        runSpeed = 20;

        transform.position = Vector3.MoveTowards(transform.position,
        player.transform.position, Time.deltaTime * walkSpeed);
        Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
        transform.position.y, player.transform.position.z);
        transform.LookAt(rotateTowardPlayer);

        playerAnims.SetBool("isWalkingForward", true);

        //Debug.Log("ChaseState");

    }

    //The character attacks the player if the player gets close enough. The character also increases its move speed. An attack animation is played.

    void AttackState()
    {
        walkSpeed = 5;
        runSpeed = 20;
        transform.position = Vector3.MoveTowards(transform.position,
        player.transform.position, Time.deltaTime * runSpeed);
        Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
        transform.position.y, player.transform.position.z);
        transform.LookAt(rotateTowardPlayer);

        playerAnims.SetBool("isWalkingForward", false);
        playerAnims.SetBool("isAttackingBlunt", true);

        //Debug.Log("AttackState");
    }

    //The wander state is not used in this case as this script is meant for monsters within the dungeons. Monsters in dungeons are not meant to move unless the player is near. 
    //There is a specific script set up with the enemy's overworld AI state machine which controls the actual wandering of the enemies.

    //void WanderState()
    //{
    //    count = 0;
    //    walkSpeed = 5;
    //    runSpeed = 20;

    //    transform.position += Vector3.forward * Time.deltaTime * walkSpeed;
    //    transform.rotation = wanderObjectForward.transform.rotation;
    //    count++;

    //    playerAnims.SetBool("isWalkingForward", true);

    //    Debug.Log("WanderState");
    //}


    //This code is supposed to make monsters move away from each other if they collide.
    private void OnTriggerStay(Collider monster)
    {
        if(monster.gameObject.tag == "Monster")
        {
            transform.position = Vector3.MoveTowards(transform.position,
            monster.transform.position, Time.deltaTime * -walkSpeed);
        }
    }

}
