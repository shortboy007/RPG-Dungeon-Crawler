using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControlCivilian : MonoBehaviour
{
    public GameObject door;

    public bool closeToPlayer;


    void Start()
    {
        door = GameObject.FindWithTag("Door");
    }

    void Update()
    {
    }
void OnTriggerExit(Collider Door)
{
    if (Door.gameObject.tag == "Door")
    {
        door.SetActive(true);
    }
}
}
