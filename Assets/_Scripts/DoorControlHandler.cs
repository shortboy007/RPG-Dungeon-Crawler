using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControlHandler : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
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
        if (Door.gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
            }
        }
    }
}
