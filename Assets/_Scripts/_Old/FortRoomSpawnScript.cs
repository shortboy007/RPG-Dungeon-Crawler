using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortRoomSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject roomSpawnActivator;
    public GameObject roomBossLair;
    public GameObject roomHallwayPath;
    public GameObject roomOnePath;
    public GameObject roomOnePathSidewaysRight;
    public GameObject roomOnePathSidewaysLeft;
    public GameObject roomFourPaths;
    public GameObject roomTurnLeft;
    public GameObject roomTurnRight;
    public GameObject roomTurnStraightFromLeft;
    public GameObject roomTurnStraightFromRight;

    public GameObject textBox;
    public Text text;

    public int count = 0;

    public bool closeToPlayer;

    public bool roomSpawnActivatorTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        textBox = GameObject.FindWithTag("NotificationText");

        spawnRooms();

        //Debug.Log("Room Number" + roomToSpawn);

        //roomSpawnActivatorTriggered = true;        
    }

    // Update is called once per frame
    void Update()
        {
                /*if (roomSpawnActivatorTriggered)
                {
                    text = textBox.GetComponent<Text>();
                    text.text = "All Rooms Spawned!";
                    roomSpawnActivatorTriggered = false;
                }*/
            }    

    public void spawnRooms()
    {
        var roomToSpawn = Random.Range(0, 3);

        if (roomToSpawn == 0)
        {
            var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, transform.position, transform.rotation);
        }
        if (roomToSpawn == 1)
        {
            var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, transform.position, transform.rotation);
        }
        if (roomToSpawn == 2)
        {
            var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, transform.position, transform.rotation);
        }
    }

    }
