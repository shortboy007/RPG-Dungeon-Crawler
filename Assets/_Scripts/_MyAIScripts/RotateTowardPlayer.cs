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
