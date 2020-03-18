using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowScript : MonoBehaviour
{
    public Animator playerAnims;

    public Transform patrolPoint1Follow;
    public Transform patrolPoint2Follow;
    public Transform patrolPoint3Follow;
    public Transform patrolPoint4Follow;
    public Transform patrolPoint5Follow;
    public Transform patrolPoint6Follow;
    public Transform patrolPoint7Follow;
    public Transform patrolPoint8Follow;
    public Transform patrolPoint9Follow;

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
            patrolPoint1Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint1 = new Vector3(patrolPoint1Follow.transform.position.x,
            transform.position.y, patrolPoint1Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint1);
        }
        if (movingToPoint2)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint2Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint2 = new Vector3(patrolPoint2Follow.transform.position.x,
            transform.position.y, patrolPoint2Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint2);
        }
        if (movingToPoint3)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint3Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint3 = new Vector3(patrolPoint3Follow.transform.position.x,
            transform.position.y, patrolPoint3Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint3);
        }
        if (movingToPoint4)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint4Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint4 = new Vector3(patrolPoint4Follow.transform.position.x,
            transform.position.y, patrolPoint4Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint4);
        }
        if (movingToPoint5)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint5Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint5 = new Vector3(patrolPoint5Follow.transform.position.x,
            transform.position.y, patrolPoint5Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint5);
        }
        if (movingToPoint6)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint6Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint6 = new Vector3(patrolPoint6Follow.transform.position.x,
            transform.position.y, patrolPoint6Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint6);
        }
        if (movingToPoint7)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint7Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint7 = new Vector3(patrolPoint7Follow.transform.position.x,
            transform.position.y, patrolPoint7Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint7);
        }
        if (movingToPoint8)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint8Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint8 = new Vector3(patrolPoint8Follow.transform.position.x,
            transform.position.y, patrolPoint8Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint8);
        }
        if (movingToPoint9)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            patrolPoint9Follow.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint9 = new Vector3(patrolPoint9Follow.transform.position.x,
            transform.position.y, patrolPoint9Follow.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint9);
        }

        if (transform.position == patrolPoint1Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint2 = true;
        }
        else if (transform.position == patrolPoint2Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint3 = true;
        }
        else if (transform.position == patrolPoint3Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint4 = true;
        }
        else if (transform.position == patrolPoint4Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint5 = true;
        }
        else if (transform.position == patrolPoint5Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint6 = true;
        }
        else if (transform.position == patrolPoint6Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint7 = true;
        }
        else if (transform.position == patrolPoint7Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint8 = true;
        }
        else if (transform.position == patrolPoint8Follow.transform.position)
        {
            setBoolsFalse();
            movingToPoint9 = true;
        }
        else if (transform.position == patrolPoint9Follow.transform.position)
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
