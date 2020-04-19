using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetreatScriptBackup : MonoBehaviour
{
    public Transform home;

    /*public Transform town1;
    public Transform town2;
    public Transform town3;
    public Transform town4;
    public Transform town5;*/

    public Animator playerAnims;

    public int walkSpeed = 5;
    public int runSpeed = 20;
    public int jumpHeight = 1;
    public int count = 0;

    /*public bool closeToT1;
    public bool closeToT2;
    public bool closeToT3;
    public bool closeToT4;
    public bool closeToT5;*/

    // Start is called before the first frame update
    void Start()
    {       
        /*town1 = GameObject.FindWithTag("T1").transform;
        town2 = GameObject.FindWithTag("T2").transform;
        town3 = GameObject.FindWithTag("T3").transform;
        town4 = GameObject.FindWithTag("T4").transform;
        town5 = GameObject.FindWithTag("T5").transform;*/
    }

    void Update()
    {
        /*float distToT1 = Vector3.Distance(this.transform.position, town1.transform.position);
        //Debug.Log("Town 1" + distToT1);
        if (distToT1 < 10000)
        {
            closeToT1 = true;
        }
        else
        {
            closeToT1 = false;
        }
        float distToT2 = Vector3.Distance(this.transform.position, town2.transform.position);
        //Debug.Log("Town 1" + distToT1);
        if (distToT2 < 10000)
        {
            closeToT2 = true;
        }
        else
        {
            closeToT2 = false;
        }
        float distToT3 = Vector3.Distance(this.transform.position, town3.transform.position);
        //Debug.Log("Town 1" + distToT1);
        if (distToT3 < 10000)
        {
            closeToT3 = true;
        }
        else
        {
            closeToT3 = false;
        }
        float distToT4 = Vector3.Distance(this.transform.position, town4.transform.position);
        //Debug.Log("Town 1" + distToT1);
        if (distToT4 < 10000)
        {
            closeToT4 = true;
        }
        else
        {
            closeToT4 = false;
        }
        float distToT5 = Vector3.Distance(this.transform.position, town5.transform.position);
        //Debug.Log("Town 1" + distToT1);
        if (distToT5 < 10000)
        {
            closeToT5 = true;
        }
        else
        {
            closeToT5 = false;
        }

        if(closeToT1)
        {
            home = GameObject.FindWithTag("T1House").transform;
        }
        else if (closeToT2)
        {
            home = GameObject.FindWithTag("T2House").transform;
        }
        else if (closeToT3)
        {
            home = GameObject.FindWithTag("T3House").transform;
        }
        else if (closeToT4)
        {
            home = GameObject.FindWithTag("T4House").transform;
        }
        else if (closeToT5)
        {
            home = GameObject.FindWithTag("T5House").transform;
        }
        else
        {
            home = GameObject.FindWithTag("House").transform;            
        }*/
        Retreat();
    }

    void Retreat()
    {
        walkSpeed = 5;
        runSpeed = 20;

        transform.position = Vector3.MoveTowards(transform.position,
        home.transform.position, Time.deltaTime * runSpeed);
        /*Vector3 rotateTowardPlayer = new Vector3(player.transform.position.x,
        transform.position.y, player.transform.position.z);
        transform.LookAt(rotateTowardPlayer);*/

        playerAnims.SetBool("isRunningForward", true);
        if (this.transform.position == home.transform.position)
        {
            playerAnims.SetBool("isRunningForward", false);
        }
    }
}
