﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveAnims : MonoBehaviour
{
    public GameObject player;
    public Animator playerAnims;
    public Animator playerAnims2;
    public Animator playerAnims3;
    public Animator playerAnims4;
    public Animator playerAnims5;
    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;

    void Start()
    {
        player = GameObject.FindWithTag("Player");

    }

    void Update()
    {
        var rotate = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        var walkForward = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;
        var runForward = Input.GetAxis("Vertical") * Time.deltaTime * runSpeed;
        var jump = Input.GetAxis("Jump") * Time.deltaTime * jumpHeight;

        transform.Translate(walkForward, 0, 0);
        transform.Rotate(0, rotate, 0);
        transform.Translate(0, jump, 0);

        if (Input.GetKey(KeyCode.W))
        {
            playerAnims.SetBool("isWalkingForward", true);
            playerAnims2.SetBool("isWalkingForward", true);
            playerAnims3.SetBool("isWalkingForward", true);
            playerAnims4.SetBool("isWalkingForward", true);
            playerAnims5.SetBool("isWalkingForward", true);
        }
        else
        {
            playerAnims.SetBool("isWalkingForward", false);
            playerAnims2.SetBool("isWalkingForward", false);
            playerAnims3.SetBool("isWalkingForward", false);
            playerAnims4.SetBool("isWalkingForward", false);
            playerAnims5.SetBool("isWalkingForward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnims.SetBool("isWalkingBackward", true);
            playerAnims2.SetBool("isWalkingBackward", true);
            playerAnims3.SetBool("isWalkingBackward", true);
            playerAnims4.SetBool("isWalkingBackward", true);
            playerAnims5.SetBool("isWalkingBackward", true);
        }
        else
        {
            playerAnims.SetBool("isWalkingBackward", false);
            playerAnims2.SetBool("isWalkingBackward", false);
            playerAnims3.SetBool("isWalkingBackward", false);
            playerAnims4.SetBool("isWalkingBackward", false);
            playerAnims5.SetBool("isWalkingBackward", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetMouseButton(2)) 
        {
            playerAnims.SetBool("isRunningForward", true);
            playerAnims2.SetBool("isRunningForward", true);
            playerAnims3.SetBool("isRunningForward", true);
            playerAnims4.SetBool("isRunningForward", true);
            playerAnims5.SetBool("isRunningForward", true);
            transform.Translate(runForward, 0, 0);
        }
        else
        {
            playerAnims.SetBool("isRunningForward", false);
            playerAnims2.SetBool("isRunningForward", false);
            playerAnims3.SetBool("isRunningForward", false);
            playerAnims4.SetBool("isRunningForward", false);
            playerAnims5.SetBool("isRunningForward", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnims.SetBool("isJumping", true);
            playerAnims.SetBool("isJumping", true);
            playerAnims2.SetBool("isJumping", true);
            playerAnims3.SetBool("isJumping", true);
            playerAnims4.SetBool("isJumping", true);
            playerAnims5.SetBool("isJumping", true);
        }
        else
        {
            playerAnims.SetBool("isJumping", false);
            playerAnims.SetBool("isJumping", false);
            playerAnims2.SetBool("isJumping", false);
            playerAnims3.SetBool("isJumping", false);
            playerAnims4.SetBool("isJumping", false);
            playerAnims5.SetBool("isJumping", false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnims.SetBool("isGrabbing", true);
            playerAnims.SetBool("isGrabbing", true);
            playerAnims2.SetBool("isGrabbing", true);
            playerAnims3.SetBool("isGrabbing", true);
            playerAnims4.SetBool("isGrabbing", true);
            playerAnims5.SetBool("isGrabbing", true);
        }
        else
        {
            playerAnims.SetBool("isGrabbing", false);
            playerAnims.SetBool("isGrabbing", false);
            playerAnims2.SetBool("isGrabbing", false);
            playerAnims3.SetBool("isGrabbing", false);
            playerAnims4.SetBool("isGrabbing", false);
            playerAnims5.SetBool("isGrabbing", false);
        }

        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(1))
        {
            playerAnims.SetBool("isAttackingBlade", true);
            playerAnims.SetBool("isAttackingBlade", true);
            playerAnims2.SetBool("isAttackingBlade", true);
            playerAnims3.SetBool("isAttackingBlade", true);
            playerAnims4.SetBool("isAttackingBlade", true);
            playerAnims5.SetBool("isAttackingBlade", true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.W) && Input.GetMouseButtonDown(1))
        {
            playerAnims.SetBool("isAttackingBlade", true);
            playerAnims.SetBool("isAttackingBlade", true);
            playerAnims2.SetBool("isAttackingBlade", true);
            playerAnims3.SetBool("isAttackingBlade", true);
            playerAnims4.SetBool("isAttackingBlade", true);
            playerAnims5.SetBool("isAttackingBlade", true);
        }
        else
        {
            playerAnims.SetBool("isAttackingBlade", false);
            playerAnims.SetBool("isAttackingBlade", false);
            playerAnims2.SetBool("isAttackingBlade", false);
            playerAnims3.SetBool("isAttackingBlade", false);
            playerAnims4.SetBool("isAttackingBlade", false);
            playerAnims5.SetBool("isAttackingBlade", false);
        }
        if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
            playerAnims.SetBool("isAttackingBlunt", true);
            playerAnims2.SetBool("isAttackingBlunt", true);
            playerAnims3.SetBool("isAttackingBlunt", true);
            playerAnims4.SetBool("isAttackingBlunt", true);
            playerAnims5.SetBool("isAttackingBlunt", true);
        }
        else if (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.J) && Input.GetMouseButtonDown(0))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
            playerAnims.SetBool("isAttackingBlunt", true);
            playerAnims2.SetBool("isAttackingBlunt", true);
            playerAnims3.SetBool("isAttackingBlunt", true);
            playerAnims4.SetBool("isAttackingBlunt", true);
            playerAnims5.SetBool("isAttackingBlunt", true);
        }
        else
        {
            playerAnims.SetBool("isAttackingBlunt", false);
            playerAnims.SetBool("isAttackingBlunt", false);
            playerAnims2.SetBool("isAttackingBlunt", false);
            playerAnims3.SetBool("isAttackingBlunt", false);
            playerAnims4.SetBool("isAttackingBlunt", false);
            playerAnims5.SetBool("isAttackingBlunt", false);
        }

        /*if (Input.GetKey(KeyCode.Y))
        {
            runSpeed = 500;
        }
        if (Input.GetKey(KeyCode.U))
        {
            runSpeed = 20;
        }*/
    }
}