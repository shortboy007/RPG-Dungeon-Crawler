using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIDungeonScript : MonoBehaviour
{
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

        idleState = true;
    }

    // Update is called once per frame
    void Update()
    {
        
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

    void stateTimer()
    {
        count++;

        if (count == 100 && wanderState)
        {

            IdleState();
            idleState = true;
            wanderState = false;
        }
        else if (count == 100 && idleState)
        {
            
            WanderState();
            idleState = false;
            wanderState = true;
        }
    }

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

    void AttackState()
    {
        walkSpeed = 5;
        runSpeed = 20;
        transform.position = Vector3.MoveTowards(transform.position,
        player.transform.position, Time.deltaTime * runSpeed);
        Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
        transform.position.y, player.transform.position.z);
        transform.LookAt(rotateTowardPlayer);

        playerAnims.SetBool("isWalkingForward", true);

        //Debug.Log("AttackState");
    }

    void WanderState()
    {
        count = 0;
        walkSpeed = 5;
        runSpeed = 20;

        transform.position += Vector3.forward * Time.deltaTime * walkSpeed;
        //transform.rotation = wanderObjectForward.transform.rotation;
            count++;

        playerAnims.SetBool("isWalkingForward", true);

        //Debug.Log("WanderState");       
    }

    private void OnTriggerStay(Collider monster)
    {
        if(monster.gameObject.tag == "Monster")
        {
            transform.position = Vector3.MoveTowards(transform.position,
            monster.transform.position, Time.deltaTime * -walkSpeed);
        }
    }

}
