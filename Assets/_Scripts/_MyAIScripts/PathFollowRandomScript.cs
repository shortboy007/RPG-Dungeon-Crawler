using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollowRandomScript : MonoBehaviour
{
    //This is a script which I was working with in order to create travel routes around the overworld map and possibly within towns as well. 
    //I wanted to make it so that the characters could travel randomly between villages on the overworld and the player could encounter them.
    //As of now this just lets the characters follow random patrol points until they reach the chosen patrol point, 
    //which causes a new point to be chosen for the character to follow.

    public Animator playerAnims;

    public GameObject patrolPoint;
    public GameObject[] patrolPoints;

    public Transform chosenPatrolPoint;

    public bool movingToPatrolPoint = false;

    public int patrolPointChosen;
    public float moveSpeed = 5;


    // Start is called before the first frame update
    void Start()
    {              
        movingToPatrolPoint = true;

        chosenPatrolPoint = GameObject.FindGameObjectWithTag("PatrolPoint").transform;

        patrolPoints = GameObject.FindGameObjectsWithTag("PatrolPoint");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        patrolPointChosen = Random.Range(0, patrolPoints.Length);

        if (movingToPatrolPoint)
        {            
            transform.position = Vector3.MoveTowards(transform.position,
            chosenPatrolPoint.transform.position, Time.deltaTime * moveSpeed);
            Vector3 rotateTowardPatrolPoint = new Vector3(chosenPatrolPoint.transform.position.x,
            transform.position.y, chosenPatrolPoint.transform.position.z);
            transform.LookAt(rotateTowardPatrolPoint);
        }

        playerAnims.SetBool("isWalkingForward", true);
    }

    public Transform choosePatrolPoint()
    {        
        patrolPointChosen = (patrolPointChosen + 1) % patrolPoints.Length;
        return patrolPoints[patrolPointChosen].transform;
    }

    void OnTriggerEnter(Collider PatrolPoint)
    {
        if (PatrolPoint.gameObject.tag == "PatrolPoint")
        {
            chosenPatrolPoint = choosePatrolPoint();
        }
    }
}
