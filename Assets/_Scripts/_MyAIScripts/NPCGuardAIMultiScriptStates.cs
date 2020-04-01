using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NPCGuardAIMultiScriptStates : MonoBehaviour
{
    public PlayerStatHandler playerStatHandler;

    public GameObject thisBody;

    public GameObject characterCustomizer;

    public Transform player;

    //public GameObject monster;
    //public GameObject[] monsters;
    public GameObject slimGuardSword;
    public GameObject muscledGuardSword;

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
        if (distToPlayer < 100)
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
        else if (closeToPlayer && tooCloseToPlayerWithWeapon && PlayerStatHandler.PeopleKilled >=1 && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {           
            AttackState();
        }
        if(thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            if (this.GetComponent<CharacterNPCRandomizer>().slimBodyChosen == true)
            {
                slimGuardSword.SetActive(true);
            }
            if (this.GetComponent<CharacterNPCRandomizer>().muscledBodyChosen == true)
            {
                muscledGuardSword.SetActive(true);
            }

        }
        else
        {
            slimGuardSword.SetActive(false);
            muscledGuardSword.SetActive(false);
        }
        if(safeDistance)
        {
           stateTimer();
        }
    }

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
