using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDungeonSpawnPoints : MonoBehaviour
{
    public GameObject spawnPoints;

    public bool spawnPointsActive = false;
    public bool spawnPointsInactive = false;

    void Start()
    {
        if (spawnPoints == null)
        {
            spawnPointsInactive = true;
            spawnPointsActive = false;
        }
        else if (spawnPoints != null)
        {
            spawnPointsActive = true;
            spawnPointsInactive = false;
        }
    }

    void Update()
    {
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.name == "Player")
        {
            if (spawnPointsInactive && Input.GetKeyDown(KeyCode.E))
            {
                spawnPoints.SetActive(true);
                spawnPointsActive = true;
                spawnPointsInactive = false;              
            }
            else if(spawnPointsActive && Input.GetKeyDown(KeyCode.E))
            {
                spawnPoints.SetActive(false);
                spawnPointsActive = false;
                spawnPointsInactive = true;
            }

        }

    }
}
