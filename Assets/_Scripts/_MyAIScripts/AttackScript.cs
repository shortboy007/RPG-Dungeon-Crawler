using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public Transform player;

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;

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
        float dist = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log(dist);
        if (dist <= 3f)
        {
            closeToPlayer = true;
        }
        else
        {
            closeToPlayer = false;
        }

        if (dist > 3f)
        {
            awayFromPlayer = true;
        }
        else
        {
            awayFromPlayer = false;
        }

        if (awayFromPlayer)
        {
            walkSpeed = 5;
            runSpeed = 20;
            transform.position = Vector3.MoveTowards(transform.position,
            player.transform.position, Time.deltaTime * walkSpeed);
            Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
            transform.position.y, player.transform.position.z);
            transform.LookAt(rotateTowardPlayer);
            playerAnims.SetBool("isAttackingBlunt", false);
            //playerAnims.SetBool("isWalkingForward", true);
            playerAnims.SetBool("isRunningForward", true);
        }
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
