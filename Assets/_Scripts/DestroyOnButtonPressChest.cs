using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnButtonPressChest : MonoBehaviour
{
    public GameObject player;

    public bool closeToPlayer;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    { 
        float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distToPlayer <= 5)
        {
            closeToPlayer = true;
        }
            if (closeToPlayer && Input.GetKeyDown(KeyCode.E))
            {
            gameObject.GetComponent<ObjectTreasureSpawnScript>().enabled = true;
            Destroy(gameObject, 1);
        }
        }
        
        }
