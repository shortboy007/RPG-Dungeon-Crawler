using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIMultiScriptStatesBackup : MonoBehaviour
{
    public Transform player;

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public static int count = 0;
    public int directionToTurn;

    public bool closeToPlayer = false;
    public bool withinAttackDistance = false;
    public bool idleState = false;
    public bool wanderState = false;
    public bool patrolState = false;
    public bool chaseState = false;
    public bool attackState = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;

        idleState = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log("Player" + distToPlayer);
        if (distToPlayer <= 30)
        {
            closeToPlayer = true;
        }
        else
        {
            closeToPlayer = false;
        }

        if(distToPlayer <= 20)
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
        else
        {
            //IdleState();
            stateTimer();
        }

    }

    void stateTimer()
    {
        count++;

        if (count == 100 && idleState)
        {
            WanderState();
            wanderState = true;
            idleState = false;
        }
        else if (count == 100 && wanderState)
        {          
            IdleState();
            idleState = true;
            wanderState = false;
        }
    }

    void IdleState()
    {
        this.GetComponent<IdleScript>().enabled = true;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        count = 0;
    }

    void ChaseState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = true;
        this.GetComponent<AttackScript>().enabled = false;
    }

    void AttackState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = false;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = true;
    }

    void WanderState()
    {
        this.GetComponent<IdleScript>().enabled = false;
        this.GetComponent<WanderScript>().enabled = true;
        this.GetComponent<ChaseScript>().enabled = false;
        this.GetComponent<AttackScript>().enabled = false;
        count = 0;
        }
    }
