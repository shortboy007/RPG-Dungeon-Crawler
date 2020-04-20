using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCGuardAIMultiScriptStates : MonoBehaviour
{

    //This script acts as a state machine for the guard NPCs within the game. There are several scripts which set up behaviors for each state that are located on the character along with this script which are
    //referenced by this script and activated or deactivated depending on various factors.

    public PlayerStatHandler playerStatHandler;

    public GameObject thisBody;

    public GameObject characterCustomizer;

    public Transform player;

    //public GameObject monster;
    //public GameObject[] monsters;
    public GameObject guardSword;

    //public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public static int count = 0;
    public int directionToTurn;
    public int peopleKilled;

    public bool closeToPlayer = false;
    public bool tooCloseToPlayerWithWeapon = false;
    public bool closeToMonster = false;
    public bool safeDistance = false;
    public bool idleState = false;
    public bool wanderState = false;
    public bool attackState = false;
    public bool chaseState = false;
    public bool retreatState = false;
    public bool returnState = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        

        //monster = GameObject.FindWithTag("Monster");
        //monsters = GameObject.FindGameObjectsWithTag("Monster");

        idleState = true;
    }

    // Update is called once per frame
    void Update()
    {        
        thisBody = GameObject.FindWithTag("ThisBody");

        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true. Otherwise, safeDistance is true.       

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
        if (distToPlayer < 1000)
        {
            tooCloseToPlayerWithWeapon = true;
        }
        else
        {
            tooCloseToPlayerWithWeapon = false;
        }
        /* float distToMonster = Vector3.Distance(this.transform.position, monster.transform.position);
         //Debug.Log("Monster" + distToMonster);
         if (distToMonster < 30)
         {
             closeToMonster = true;
         }
         else
         {
             closeToMonster = false;
         }*/

        if (closeToPlayer)
        {
            ChaseState();
        }

        //If the character is too close to the player and the player has a weapon out, the attack state is set to true.

        else if (tooCloseToPlayerWithWeapon && PlayerStatHandler.PeopleKilled >=1 && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {           
            AttackState();
        }
        else if(safeDistance)
        {
           stateTimer();
        }

        //If the player has a weapon out, the character pulls out his sword and the character's sword game object is set active.

        if (thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            if (this.GetComponent<CharacterNPCRandomizer>().bodyChosen == true)
            {
                guardSword.SetActive(true);
            }

        }
        else
        {
            guardSword.SetActive(false);
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
        }
        if (count > 100 && attackState)
        {
            ReturnState();
            idleState = false;
            wanderState = false;
            attackState = false;
            returnState = true;
        }
        if (count > 100 && chaseState)
        {
            IdleState();
            idleState = true;
            wanderState = false;
            chaseState = false;
            returnState = false;
            retreatState = false;
        }
    }

    //For each state, when a boolean is activated such as idleState or WanderState, that specific script and boolean which are located on the character gameobject are set active while the other scripts and booleans are deactivated.

    void IdleState()
    {

            this.GetComponent<IdleScript>().enabled = true;
            this.GetComponent<WanderScript>().enabled = false;
            this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        count = 0;
        idleState = true;
        wanderState = false;
        returnState = false;
        attackState = false;
    }
    void AttackState()
    {
            this.GetComponent<IdleScript>().enabled = false;
            this.GetComponent<WanderScript>().enabled = false;
            this.GetComponent<AttackScript>().enabled = true;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = false;
        returnState = false;
        attackState = true;
    }
    void ChaseState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = true;
        this.GetComponent<ReturnScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = true;
        returnState = false;
        attackState = false;
        chaseState = false;
    }
    void ReturnState()
    {

        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = true;
        count = 0;
        idleState = false;
        wanderState = false;
        returnState = true;
        attackState = false;
    }
    void WanderState()
    {
            this.GetComponent<IdleScript>().enabled = false;
            this.GetComponent<WanderScript>().enabled = true;
            this.GetComponent<AttackScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<ReturnScript>().enabled = false;
        count = 0;
        idleState = false;
        wanderState = true;
        returnState = false;
        attackState = false;
    }

    //This little bit of code was a test to see if I could set up the stateTimer method with random values. The version which is used now seems to work much better.

    /*void WanderOrReturn()
    {
        count = 0;
        var wanderOrReturn = Random.Range(0, 1);  
        
        if (wanderOrReturn == 0)
        {
            WanderState();
            wanderState = true;
            idleState = false;
            returnState = false;
        }
        else if (wanderOrReturn == 1)
        {
            ReturnState();
            wanderState = false;
            idleState = false;
            returnState = true;
        }
    }*/

}
