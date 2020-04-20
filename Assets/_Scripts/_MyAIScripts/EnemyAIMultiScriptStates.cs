using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIMultiScriptStates : MonoBehaviour
{ 

    //This script acts as a state machine for the enemies within the game. There are several scripts which set up behaviors for each state that are located on the character along with this script which are
    //referenced by this script and activated or deactivated depending on various factors.

public PlayerStatHandler playerStatHandler;

public Transform player;
//public GameObject monster;
//public GameObject[] monsters;

//public Animator playerAnims;

public int walkSpeed = 5;
public int runSpeed = 20;
public int jumpHeight = 1;
public static int count = 0;
public int directionToTurn;
public int peopleKilled;

public bool inDungeon = false;
public bool closeToPlayer = false;
public bool tooCloseToPlayerWithWeapon = false;
public bool closeToMonster = false;
public bool safeDistance = false;
public bool idleState = false;
public bool wanderState = false;
public bool attackState = false;
public bool retreatState = false;
public bool returnState = false;

// Start is called before the first frame update
void Start()
{
    player = GameObject.FindWithTag("Player").transform;
    //monster = GameObject.FindWithTag("Monster");
    //monsters = GameObject.FindGameObjectsWithTag("Monster");

    idleState = true;
    //inDungeon = false;
}

// Update is called once per frame
void Update()
{
        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true. Otherwise, safeDistance is true;        

        float distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
    //Debug.Log("Player" + distToPlayer);
    if (distToPlayer <= 10)
    {
        closeToPlayer = true;
        safeDistance = false;
    }
    else
    {
        closeToPlayer = false;
        safeDistance = true;
    }
        
    if (closeToPlayer)
    {
        AttackState();
    }

    //This bit of commented out script is set up to make the monsters run away from the player if the player has a weapon out and has killed enough monsters to be considered a threat and terror to them.

    //if (distToPlayer <= 5)
    //{
    //    tooCloseToPlayerWithWeapon = true;
    //}
    //else
    //{
    //    tooCloseToPlayerWithWeapon = false;
    //}


        /*if (tooCloseToPlayerWithWeapon && PlayerStatHandler.MonstersKilled >= 100 && player.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false)
        {
            RetreatState();
        }*/
        /*if (inDungeon && safeDistance)
        {
            IdleState();
        }
        else if (!inDungeon && safeDistance)
        {
            stateTimer();
        }*/
        if (safeDistance)
    {
        stateTimer();
    }
}

    //This stateTimer method adds to the count variable every frame and when it gets to 100, the character's behavior shifts from the idle state to the wander state. 
    //The count variable is then set to 0 and starts again. The stateTimer in this case also takes into account the different behaviors and states which the character has.
    //It has if statements which look for which boolean or state is active at the time and then if the conditions for that boolean are not met after count reaches 100, the default idle state is set as the behavior.
    //The default stateTimer code switches back and forth between idle state and wander state until the player is seen.

    void stateTimer()
{
    count++;
    if (count > 100 && idleState)
    {
        //WanderOrReturn();
        WanderState();
        wanderState = true;
        idleState = false;
    }
    if (count > 100 && wanderState)
    {
        //WanderOrReturn();
        IdleState();
        idleState = true;
        wanderState = false;
    }
    if (count > 100 && returnState)
    {
        IdleState();
        idleState = true;
        wanderState = false;
        attackState = false;
        returnState = false;
        retreatState = false;
        }
    if (count > 100 && retreatState)
    {
        ReturnState();
        idleState = false;
        wanderState = false;
        attackState = false;
        returnState = true;
        retreatState = false;
    }
        if (count > 100 && attackState)
    {
        ReturnState();
        idleState = false;
        wanderState = false;
        attackState = false;
        returnState = true;
        retreatState = false;
        }
}
    //For each state, when a boolean is activated such as idleState or WanderState, that specific script and boolean which are located on the character gameobject are set active while the other scripts and booleans are deactivated.

    void IdleState()
    {

        this.GetComponent<IdleScript>().enabled = true;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        this.GetComponent<RetreatScript>().enabled = false;
        count = 0;
        idleState = true;
        wanderState = false;
        returnState = false;
        retreatState = false;
        attackState = false;
    }
    void AttackState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = true;
        this.GetComponent<ReturnScript>().enabled = false;
        this.GetComponent<RetreatScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = false;
        returnState = false;
        retreatState = false;
        attackState = true;
    }
    void ReturnState()
    {

        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = true;
        this.GetComponent<RetreatScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = false;
        returnState = true;
        retreatState = false;
        attackState = false;
    }
    void RetreatState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        this.GetComponent<RetreatScript>().enabled = true;
        count = 0;
        idleState = false;
        wanderState = false;
        returnState = false;
        retreatState = true;
        attackState = false;
    }
    void WanderState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = true;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        this.GetComponent<RetreatScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = true;
        returnState = false;
        retreatState = false;
        attackState = false;
    }

    //This code is supposed to make monsters move away from each other if they collide.
    private void OnTriggerStay(Collider monster)
    {
        if (monster.gameObject.tag == "Monster")
        {
            transform.position = Vector3.MoveTowards(transform.position,
            monster.transform.position, Time.deltaTime * -walkSpeed);
        }

        /*if (monster.gameObject.tag == "Dungeon")
        {
            inDungeon = true;
        }*/
    }
}
