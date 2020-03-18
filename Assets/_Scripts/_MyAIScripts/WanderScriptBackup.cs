﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderScriptBackup : MonoBehaviour
{
    public Transform wanderObjectForward;
    public Transform wanderObjectBackward;
    public Transform wanderObjectRight;
    public Transform wanderObjectLeft;

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;
    public int directionToTurn;

    public bool hitWOF = false;
    public bool hitWOB = false;
    public bool hitWOR = false;
    public bool hitWOL = false;

    // Start is called before the first frame update
    void Start()
    {

        /*wanderObjectForward = GameObject.FindWithTag("WOF").transform;
        wanderObjectBackward = GameObject.FindWithTag("WOB").transform;
        wanderObjectRight = GameObject.FindWithTag("WOR").transform;
        wanderObjectLeft = GameObject.FindWithTag("WOL").transform;*/

    }

    void Update()
    {
        count++;

        if(count == 100)
        {
            directionToTurn = Random.Range(0, 4);
            Wander();
        }
        
        if (directionToTurn == 0)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            wanderObjectForward.transform.position, Time.deltaTime * walkSpeed);
            transform.rotation = wanderObjectForward.transform.rotation;
            //Debug.Log("Forward");
        }
        else if (directionToTurn == 1)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            wanderObjectBackward.transform.position, Time.deltaTime * walkSpeed);
            transform.rotation = wanderObjectBackward.transform.rotation;
            //Debug.Log("Backward");
        }
        else if (directionToTurn == 2)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            wanderObjectRight.transform.position, Time.deltaTime * walkSpeed);
            transform.rotation = wanderObjectRight.transform.rotation;
            //Debug.Log("Right");
        }
        else if (directionToTurn == 3)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            wanderObjectLeft.transform.position, Time.deltaTime * walkSpeed);
            transform.rotation = wanderObjectLeft.transform.rotation;
            //Debug.Log("Left");
        }

        playerAnims.SetBool("isWalkingForward", true);
    }
    void Wander()
    {
        count = 0;
        walkSpeed = 10;
        runSpeed = 20;
    }
}