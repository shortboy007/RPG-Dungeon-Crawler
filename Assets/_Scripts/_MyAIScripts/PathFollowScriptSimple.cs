using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowScriptSimple : MonoBehaviour
{
    //This is a script which I was working with in order to create travel routes around the overworld map and possibly within towns as well. 
    //I wanted to make it so that the characters could travel set paths between villages on the overworld and the player could encounter them.
    //I wanted to be able to make specific paths for guards to follow as if they were on patrol.
    //I also thought that it might be interesting to have a racing mechanic set up in a minigame as well which would use this patrol point 
    //method for the AI the player would be racing.
    //As of now this just lets the characters follow set patrol points until they reach the chosen patrol point, 
    //which causes the next point to be chosen for the character to follow.

    public Animator playerAnims;

    public Transform patrolPoint1;
    public Transform patrolPoint2;
    public Transform patrolPoint3;
    public Transform patrolPoint4;
    public Transform patrolPoint5;
    public Transform patrolPoint6;
    public Transform patrolPoint7;
    public Transform patrolPoint8;
    public Transform patrolPoint9;

    public bool movingToPoint1 = false;
    public bool movingToPoint2 = false;
    public bool movingToPoint3 = false;
    public bool movingToPoint4 = false;
    public bool movingToPoint5 = false;
    public bool movingToPoint6 = false;
    public bool movingToPoint7 = false;
    public bool movingToPoint8 = false;
    public bool movingToPoint9 = false;

    public float moveSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {   
        movingToPoint1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (movingToPoint1)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint1.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint1 = new Vector3(patrolPoint1.transform.position.x,
            transform.position.y, patrolPoint1.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint1);
        }
        if (movingToPoint2)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint2.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint2 = new Vector3(patrolPoint2.transform.position.x,
            transform.position.y, patrolPoint2.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint2);
        }
        if (movingToPoint3)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint3.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint3 = new Vector3(patrolPoint3.transform.position.x,
            transform.position.y, patrolPoint3.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint3);
        }
        if (movingToPoint4)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint4.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint4 = new Vector3(patrolPoint4.transform.position.x,
            transform.position.y, patrolPoint4.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint4);
        }
        if (movingToPoint5)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint5.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint5 = new Vector3(patrolPoint5.transform.position.x,
            transform.position.y, patrolPoint5.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint5);
        }
        if (movingToPoint6)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint6.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint6 = new Vector3(patrolPoint6.transform.position.x,
            transform.position.y, patrolPoint6.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint6);
        }
        if (movingToPoint7)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint7.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint7 = new Vector3(patrolPoint7.transform.position.x,
            transform.position.y, patrolPoint7.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint7);
        }
        if (movingToPoint8)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint8.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint8 = new Vector3(patrolPoint8.transform.position.x,
            transform.position.y, patrolPoint8.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint8);
        }
        if (movingToPoint9)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint9.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint9 = new Vector3(patrolPoint9.transform.position.x,
            transform.position.y, patrolPoint9.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint9);
        }

        if (transform.position == patrolPoint1.transform.position)
        {
            setBoolsFalse();
            movingToPoint2 = true;
        }
        else if (transform.position == patrolPoint2.transform.position)
        {
            setBoolsFalse();
            movingToPoint3 = true;
        }
        else if (transform.position == patrolPoint3.transform.position)
        {
            setBoolsFalse();
            movingToPoint4 = true;
        }
        else if (transform.position == patrolPoint4.transform.position)
        {
            setBoolsFalse();
            movingToPoint5 = true;
        }
        else if (transform.position == patrolPoint5.transform.position)
        {
            setBoolsFalse();
            movingToPoint6 = true;
        }
        else if (transform.position == patrolPoint6.transform.position)
        {
            setBoolsFalse();
            movingToPoint7 = true;
        }
        else if (transform.position == patrolPoint7.transform.position)
        {
            setBoolsFalse();
            movingToPoint8 = true;
        }
        else if (transform.position == patrolPoint8.transform.position)
        {
            setBoolsFalse();
            movingToPoint9 = true;
        }
        else if (transform.position == patrolPoint9.transform.position)
        {
            setBoolsFalse();
            movingToPoint1 = true;
        }

        playerAnims.SetBool("isWalkingForward", true);
    }

    public void setBoolsFalse()
    {
    movingToPoint1 = false;
    movingToPoint2 = false;
    movingToPoint3 = false;
    movingToPoint4 = false;
    movingToPoint5 = false;
    movingToPoint6 = false;
    movingToPoint7 = false;
    movingToPoint8 = false;
    movingToPoint9 = false;
}
}
