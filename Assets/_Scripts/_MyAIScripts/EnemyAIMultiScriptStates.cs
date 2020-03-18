using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIMultiScriptStates : MonoBehaviour
{ 
public PlayerStatHandler playerStatHandler;

public Transform player;
//public GameObject monster;
//public GameObject[] monsters;

public Animator playerAnims;

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
    float distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
    //Debug.Log("Player" + distToPlayer);
    if (distToPlayer <= 100)
    {
        closeToPlayer = true;
    }
    else
    {
        closeToPlayer = false;
    }
    if (distToPlayer <= 50)
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

    if (distToPlayer > 200 /*&& distToMonster > 30*/)
    {
        safeDistance = true;
    }
    else
    {
        safeDistance = false;
    }

    if (closeToPlayer)
    {
        AttackState();
    }
        /*if (tooCloseToPlayerWithWeapon && PlayerStatHandler.MonstersKilled >= 100 && player.GetComponent<WeaponSelectHandlerV2>().notHoldingWeapon == false)
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
