using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDungeonSweep : MonoBehaviour
{
    public GameObject dungeonSweeper;

    public bool dungeonSweeperActive = false;
    public bool dungeonSweeperInactive = false;

    void Start()
    {
        if (dungeonSweeper == null)
        {
            dungeonSweeperInactive = true;
            dungeonSweeperActive = false;
        }
        else if (dungeonSweeper != null)
        {
            dungeonSweeperActive = true;
            dungeonSweeperInactive = false;
        }
    }

    void Update()
    {
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.name == "Player")
        {
            if (dungeonSweeperInactive && Input.GetKeyDown(KeyCode.E))
            {
                dungeonSweeper.SetActive(true);
                dungeonSweeperActive = true;
                dungeonSweeperInactive = false;
            }
            else if (dungeonSweeperActive && Input.GetKeyDown(KeyCode.E))
            {
                dungeonSweeper.SetActive(false);
                dungeonSweeperInactive = true;
                dungeonSweeperActive = false;
            }

        }

    }
}
