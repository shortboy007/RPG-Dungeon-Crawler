using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardPlayer : MonoBehaviour
{
    public Transform player;

    public bool closeToPlayer = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        //If the player is within a certain distance of the gameobject or character that this script is active on, the boolean closeToPlayer is true.
        //If closeToPlayer is true, the gameobject will rotate towards the player. This was originally meant to be placed on an NPC's head or eye objects
        //so that the character could look at the player while still going about their business.

        float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        //Debug.Log("Player" + distToPlayer);
        if (distToPlayer <= 25)
        {
            closeToPlayer = true;
        }
        else
        {
            closeToPlayer = false;
        }

        Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
        transform.position.y, player.transform.position.z);
        transform.LookAt(rotateTowardPlayer);
    }
}
