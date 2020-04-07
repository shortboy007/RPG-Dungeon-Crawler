using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleScript : MonoBehaviour
{
    public Animator playerAnims;
    public Animator playerAnims2;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count;
    public int directionToTurn;

    public bool closeToPlayer;

    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        Idle();
    }

    void Idle()
    {
        walkSpeed = 0;
        runSpeed = 0;

        playerAnims.SetBool("isWalkingForward", false);
        if (playerAnims2 != null)
        {
            playerAnims2.SetBool("isWalkingForward", false);
        }
    }
}
