using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorControlHandler : MonoBehaviour
{
    public GameObject player;
    public GameObject key;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //key = GameObject.FindWithTag("Key");
    }

    void Update()
    {
    }
    /*void OnTriggerEnter(Collider Door)
    {
        if (Door.gameObject.tag == "Civilian")
        {
            gameObject.SetActive(false);
        }
    }*/

    private void OnTriggerStay(Collider Door)       
    {
        if (Door.gameObject.tag == "Player" && player.GetComponent<WeaponSelectHandlerV2>().holdingKey == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
