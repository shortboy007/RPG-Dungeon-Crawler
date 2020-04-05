using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{

    public Transform player;

    public Animator playerAnims;
    public Animator playerAnims2;

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
            float distToPlayer = Vector3.Distance(this.transform.position, player.transform.position);
            //Debug.Log("Player" + distToPlayer);
            if (distToPlayer <= 5)
            {
                closeToPlayer = true;
            }
            else
            {
                closeToPlayer = false;
            }

            if (!closeToPlayer)
            {
                walkSpeed = 5;
                runSpeed = 20;
                transform.position = Vector3.MoveTowards(transform.position,
                player.transform.position, Time.deltaTime * walkSpeed);
                Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
                transform.position.y, player.transform.position.z);
                transform.LookAt(rotateTowardPlayer);
            
                playerAnims.SetBool("isRunningForward", true);
            if (playerAnims2 != null)
            {
                playerAnims2.SetBool("isRunningForward", true);
            }

        }
            if (closeToPlayer)
            {
                walkSpeed = 0;
                runSpeed = 0;
                Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
                transform.position.y, player.transform.position.z);
                transform.LookAt(rotateTowardPlayer);
        }
        }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
                playerAnims.SetBool("isAttackingBlunt", true);
                //playerAnims.SetBool("isWalkingForward", false);
                playerAnims.SetBool("isRunningForward", false);
                if (playerAnims2 != null)
                {
                    playerAnims2.SetBool("isAttackingBlunt", true);
                    playerAnims2.SetBool("isRunningForward", false);
                }
            }
        }
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            playerAnims.SetBool("isAttackingBlunt", false);
            if (playerAnims2 != null)
            {
                playerAnims2.SetBool("isAttackingBlunt", false);
            }
        }
    }
}
