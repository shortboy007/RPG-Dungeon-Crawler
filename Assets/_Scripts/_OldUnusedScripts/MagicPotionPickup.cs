using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPotionPickup : MonoBehaviour
{
    public GameObject player;
    public Transform playerHand;

    //public int count;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerHand = GameObject.FindWithTag("PlayerGrabLocation").transform;

    }

    // Update is called once per frame
    void Update()
    {
        //GetComponent<Rigidbody>().isKinematic = true;
        //GetComponent<Rigidbody>().useGravity = false;
        transform.position = playerHand.transform.position;
    }
}
