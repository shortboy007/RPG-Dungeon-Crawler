using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerMoveAnimsNetwork : NetworkBehaviour
{
    public GameObject player;
    public GameObject player2;
    public Animator playerAnims;
    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;

    void Start()
    {

        player = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");

        if (player == null)
        {
            gameObject.tag = "Player";
        }
        else if (player != null && player2 == null)
        {
            gameObject.tag = "Player2";
        }
    }

    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }

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
        }
        else
        {
            playerAnims.SetBool("isWalkingForward", false);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerAnims.SetBool("isWalkingBackward", true);
        }
        else
        {
            playerAnims.SetBool("isWalkingBackward", false);
        }
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            playerAnims.SetBool("isRunningForward", true);
            transform.Translate(runForward, 0, 0);
        }
        else
        {
            playerAnims.SetBool("isRunningForward", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerAnims.SetBool("isJumping", true);
        }
        else
        {
            playerAnims.SetBool("isJumping", false);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnims.SetBool("isGrabbing", true);
        }
        else
        {
            playerAnims.SetBool("isGrabbing", false);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            playerAnims.SetBool("isAttackingBlade", true);
        }
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.K))
        {
            playerAnims.SetBool("isAttackingBlade", true);
        }
        else
        {
            playerAnims.SetBool("isAttackingBlade", false);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
        }
        else if (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.W))
        {
            playerAnims.SetBool("isAttackingBlunt", true);
        }
        else
        {
            playerAnims.SetBool("isAttackingBlunt", false);
        }
    }
}
