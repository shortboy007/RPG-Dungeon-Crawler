using System.Collections;
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

    public bool autoWalking = false;

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

        //if(autoWalking)
        //{
        //    transform.position =  * Time.deltaTime * walkSpeed;
        //    playerAnims.SetBool("isWalkingForward", true);
        //    playerAnims2.SetBool("isWalkingForward", true);
        //    playerAnims3.SetBool("isWalkingForward", true);
        //    playerAnims4.SetBool("isWalkingForward", true);
        //    playerAnims5.SetBool("isWalkingForward", true);
        //}

        //if (Input.GetKey(KeyCode.I))
        //{
        //    if(!autoWalking)
        //    {
        //        autoWalking = true; 
        //    }
        //    else if(autoWalking)
        //    {
        //        autoWalking = false;
        //    }                     
        //}

            if (Input.GetKey(KeyCode.W))
        {
            playerAnims.SetBool("isWalkingForward", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isWalkingForward", true);
                playerAnims3.SetBool("isWalkingForward", true);
                playerAnims4.SetBool("isWalkingForward", true);
                playerAnims5.SetBool("isWalkingForward", true);
            }
        }
        else
        {
            playerAnims.SetBool("isWalkingForward", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isWalkingForward", false);
                playerAnims3.SetBool("isWalkingForward", false);
                playerAnims4.SetBool("isWalkingForward", false);
                playerAnims5.SetBool("isWalkingForward", false);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnims.SetBool("isWalkingBackward", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isWalkingBackward", true);
                playerAnims3.SetBool("isWalkingBackward", true);
                playerAnims4.SetBool("isWalkingBackward", true);
                playerAnims5.SetBool("isWalkingBackward", true);
            }
        }
        else
        {
            playerAnims.SetBool("isWalkingBackward", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isWalkingBackward", false);
                playerAnims3.SetBool("isWalkingBackward", false);
                playerAnims4.SetBool("isWalkingBackward", false);
                playerAnims5.SetBool("isWalkingBackward", false);
            }
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
        {
            playerAnims.SetBool("isRunningForward", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isRunningForward", true);
                playerAnims3.SetBool("isRunningForward", true);
                playerAnims4.SetBool("isRunningForward", true);
                playerAnims5.SetBool("isRunningForward", true);
                
            }
            transform.Translate(runForward, 0, 0);
        }
        else
        {
            playerAnims.SetBool("isRunningForward", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isRunningForward", false);
                playerAnims3.SetBool("isRunningForward", false);
                playerAnims4.SetBool("isRunningForward", false);
                playerAnims5.SetBool("isRunningForward", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnims.SetBool("isJumping", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isJumping", true);
                playerAnims3.SetBool("isJumping", true);
                playerAnims4.SetBool("isJumping", true);
                playerAnims5.SetBool("isJumping", true);
            }
        }
        else
        {
            playerAnims.SetBool("isJumping", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isJumping", false);
                playerAnims3.SetBool("isJumping", false);
                playerAnims4.SetBool("isJumping", false);
                playerAnims5.SetBool("isJumping", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnims.SetBool("isAttackingRanged", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingRanged", true);
                playerAnims3.SetBool("isAttackingRanged", true);
                playerAnims4.SetBool("isAttackingRanged", true);
                playerAnims5.SetBool("isAttackingRanged", true);
            }
        }
        else
        {
            playerAnims.SetBool("isAttackingRanged", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingRanged", false);
                playerAnims3.SetBool("isAttackingRanged", false);
                playerAnims4.SetBool("isAttackingRanged", false);
                playerAnims5.SetBool("isAttackingRanged", false);
            }
        }

        if (Input.GetKeyDown(KeyCode.K) || Input.GetMouseButtonDown(1) || Input.GetKey(KeyCode.K) || Input.GetMouseButton(1))
        {
            playerAnims.SetBool("isAttackingBlade", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlade", true);
                playerAnims3.SetBool("isAttackingBlade", true);
                playerAnims4.SetBool("isAttackingBlade", true);
                playerAnims5.SetBool("isAttackingBlade", true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.K) || Input.GetKeyDown(KeyCode.W) && Input.GetMouseButtonDown(1) || Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.K) || Input.GetKey(KeyCode.W) && Input.GetMouseButton(1))
        {
            playerAnims.SetBool("isAttackingBlade", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlade", true);
                playerAnims3.SetBool("isAttackingBlade", true);
                playerAnims4.SetBool("isAttackingBlade", true);
                playerAnims5.SetBool("isAttackingBlade", true);
            }
        }
        else
        {
            playerAnims.SetBool("isAttackingBlade", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlade", false);
                playerAnims3.SetBool("isAttackingBlade", false);
                playerAnims4.SetBool("isAttackingBlade", false);
                playerAnims5.SetBool("isAttackingBlade", false);
            }
        }
        if (Input.GetKeyDown(KeyCode.J) || Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.J) || Input.GetMouseButton(0))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlunt", true);
                playerAnims3.SetBool("isAttackingBlunt", true);
                playerAnims4.SetBool("isAttackingBlunt", true);
                playerAnims5.SetBool("isAttackingBlunt", true);
            }
        }
        else if (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.J) && Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.J) && Input.GetMouseButton(0))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlunt", true);
                playerAnims3.SetBool("isAttackingBlunt", true);
                playerAnims4.SetBool("isAttackingBlunt", true);
                playerAnims5.SetBool("isAttackingBlunt", true);
            }
        }
        else
        {
            playerAnims.SetBool("isAttackingBlunt", false);
            if (playerAnims2 != null || playerAnims3 != null || playerAnims4 != null || playerAnims5 != null)
            {
                playerAnims2.SetBool("isAttackingBlunt", false);
                playerAnims3.SetBool("isAttackingBlunt", false);
                playerAnims4.SetBool("isAttackingBlunt", false);
                playerAnims5.SetBool("isAttackingBlunt", false);
            }
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
