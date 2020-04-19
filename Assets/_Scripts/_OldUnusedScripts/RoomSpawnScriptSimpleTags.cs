using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSpawnScriptSimpleTags : MonoBehaviour
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


    public Transform roomSpawnPoint;
    public Transform roomSpawnPoint2;
    public Transform roomSpawnPoint3;
    public Transform roomSpawnPoint4;
    public Transform roomSpawnPoint5;
    public Transform roomSpawnPoint6;
    public Transform roomSpawnPoint7;
    public Transform roomSpawnPoint8;
    public Transform roomSpawnPoint9;
    public Transform roomSpawnPoint10;

    public Transform roomSpawnPoint11;
    public Transform roomSpawnPoint12;
    public Transform roomSpawnPoint13;
    public Transform roomSpawnPoint14;
    public Transform roomSpawnPoint15;
    public Transform roomSpawnPoint16;
    public Transform roomSpawnPoint17;
    public Transform roomSpawnPoint18;
    public Transform roomSpawnPoint19;
    public Transform roomSpawnPoint20;

    public Transform roomSpawnPoint21;
    public Transform roomSpawnPoint22;
    public Transform roomSpawnPoint23;
    public Transform roomSpawnPoint24;
    public Transform roomSpawnPoint25;
    public Transform roomSpawnPoint26;
    public Transform roomSpawnPoint27;
    public Transform roomSpawnPoint28;
    public Transform roomSpawnPoint29;
    public Transform roomSpawnPoint30;
    public Transform roomSpawnPoint31;


    public GameObject textBox;
    public Text text;

    public bool closeToPlayer;

    public bool roomSpawnActivatorTriggered = false;
    public bool noRoomsSpawned;
    public bool room1Spawned = false;
    public bool room2Spawned = false;
    public bool room3Spawned = false;
    public bool room4Spawned = false;
    public bool room5Spawned = false;
    public bool room6Spawned = false;
    public bool room7Spawned = false;
    public bool room8Spawned = false;
    public bool room9Spawned = false;
    public bool room10Spawned = false;

    public bool room11Spawned = false;
    public bool room12Spawned = false;
    public bool room13Spawned = false;
    public bool room14Spawned = false;
    public bool room15Spawned = false;
    public bool room16Spawned = false;
    public bool room17Spawned = false;
    public bool room18Spawned = false;
    public bool room19Spawned = false;
    public bool room20Spawned = false;

    public bool room21Spawned = false;
    public bool room22Spawned = false;
    public bool room23Spawned = false;
    public bool room24Spawned = false;
    public bool room25Spawned = false;
    public bool room26Spawned = false;
    public bool room27Spawned = false;
    public bool room28Spawned = false;
    public bool room29Spawned = false;
    public bool room30Spawned = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        roomSpawnActivator = GameObject.FindWithTag("RoomSpawnActivator");

        roomSpawnPoint = GameObject.FindWithTag("RoomSpawnPoint").transform;
        roomSpawnPoint2 = GameObject.FindWithTag("RoomSpawnPoint2").transform;
        roomSpawnPoint3 = GameObject.FindWithTag("RoomSpawnPoint3").transform;
        roomSpawnPoint4 = GameObject.FindWithTag("RoomSpawnPoint4").transform;
        roomSpawnPoint5 = GameObject.FindWithTag("RoomSpawnPoint5").transform;
        roomSpawnPoint6 = GameObject.FindWithTag("RoomSpawnPoint6").transform;
        roomSpawnPoint7 = GameObject.FindWithTag("RoomSpawnPoint7").transform;
        roomSpawnPoint8 = GameObject.FindWithTag("RoomSpawnPoint8").transform;
        roomSpawnPoint9 = GameObject.FindWithTag("RoomSpawnPoint9").transform;
        roomSpawnPoint10 = GameObject.FindWithTag("RoomSpawnPoint10").transform;

        roomSpawnPoint11 = GameObject.FindWithTag("RoomSpawnPoint11").transform;
        roomSpawnPoint12 = GameObject.FindWithTag("RoomSpawnPoint12").transform;
        roomSpawnPoint13 = GameObject.FindWithTag("RoomSpawnPoint13").transform;
        roomSpawnPoint14 = GameObject.FindWithTag("RoomSpawnPoint14").transform;
        roomSpawnPoint15 = GameObject.FindWithTag("RoomSpawnPoint15").transform;
        roomSpawnPoint16 = GameObject.FindWithTag("RoomSpawnPoint16").transform;
        roomSpawnPoint17 = GameObject.FindWithTag("RoomSpawnPoint17").transform;
        roomSpawnPoint18 = GameObject.FindWithTag("RoomSpawnPoint18").transform;
        roomSpawnPoint19 = GameObject.FindWithTag("RoomSpawnPoint19").transform;
        roomSpawnPoint20 = GameObject.FindWithTag("RoomSpawnPoint20").transform;

        roomSpawnPoint21 = GameObject.FindWithTag("RoomSpawnPoint21").transform;
        roomSpawnPoint22 = GameObject.FindWithTag("RoomSpawnPoint22").transform;
        roomSpawnPoint23 = GameObject.FindWithTag("RoomSpawnPoint23").transform;
        roomSpawnPoint24 = GameObject.FindWithTag("RoomSpawnPoint24").transform;
        roomSpawnPoint25 = GameObject.FindWithTag("RoomSpawnPoint25").transform;
        roomSpawnPoint26 = GameObject.FindWithTag("RoomSpawnPoint26").transform;
        roomSpawnPoint27 = GameObject.FindWithTag("RoomSpawnPoint27").transform;
        roomSpawnPoint28 = GameObject.FindWithTag("RoomSpawnPoint28").transform;
        roomSpawnPoint29 = GameObject.FindWithTag("RoomSpawnPoint29").transform;
        roomSpawnPoint30 = GameObject.FindWithTag("RoomSpawnPoint30").transform;
        roomSpawnPoint31 = GameObject.FindWithTag("RoomSpawnPoint31").transform;

        //roomActivatorPoint = GameObject.FindWithTag("RoomSpawnActivator").transform;

        textBox = GameObject.FindWithTag("NotificationText");

        noRoomsSpawned = true;
    }

    // Update is called once per frame
    void Update()
        { 
        float distToPlayer = Vector3.Distance(roomSpawnActivator.transform.position, player.transform.position);
        if (distToPlayer <= 4)
        {
            closeToPlayer = true;
        }
            if (closeToPlayer && Input.GetKeyDown(KeyCode.E))
            {
            Destroy(roomSpawnActivator);

            if (noRoomsSpawned)
            {
                var roomToSpawn = Random.Range(0, 3);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint.position, roomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint.position, roomSpawnPoint.rotation);
                }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint.position, roomSpawnPoint.rotation);
                }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
                room1Spawned = true;
                noRoomsSpawned = false;
            }
        }

        if (room1Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint2.position, roomSpawnPoint2.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint2.position, roomSpawnPoint2.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint2.position, roomSpawnPoint2.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room2Spawned = true;
        }

        if (room2Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint3.position, roomSpawnPoint3.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint3.position, roomSpawnPoint3.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint3.position, roomSpawnPoint3.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room3Spawned = true;
        }

        if (room3Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint4.position, roomSpawnPoint4.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint4.position, roomSpawnPoint4.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint4.position, roomSpawnPoint4.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room4Spawned = true;
        }

        if (room4Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint5.position, roomSpawnPoint5.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint5.position, roomSpawnPoint5.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint5.position, roomSpawnPoint5.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room5Spawned = true;
        }

        if (room5Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint6.position, roomSpawnPoint6.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint6.position, roomSpawnPoint6.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint6.position, roomSpawnPoint6.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room6Spawned = true;
        }

        if (room6Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint7.position, roomSpawnPoint7.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint7.position, roomSpawnPoint7.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint7.position, roomSpawnPoint7.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room7Spawned = true;
        }

        if (room7Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint8.position, roomSpawnPoint8.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint8.position, roomSpawnPoint8.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint8.position, roomSpawnPoint8.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room8Spawned = true;
        }

        if (room8Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint9.position, roomSpawnPoint9.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint9.position, roomSpawnPoint9.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint9.position, roomSpawnPoint9.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room9Spawned = true;
        }

        if (room9Spawned)
        {
        var roomToSpawn = Random.Range(0, 3);

        if (roomToSpawn == 0)
        {
            var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint10.position, roomSpawnPoint10.rotation);
        }
        if (roomToSpawn == 1)
        {
            var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint10.position, roomSpawnPoint10.rotation);
        }
        if (roomToSpawn == 2)
        {
            var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint10.position, roomSpawnPoint10.rotation);
        }

        //Debug.Log("Room Number" + roomToSpawn);

        roomSpawnActivatorTriggered = true;
        room10Spawned = true;
    }

        if (room10Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint11.position, roomSpawnPoint11.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint11.position, roomSpawnPoint11.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint11.position, roomSpawnPoint11.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room11Spawned = true;
        }  

        if (room11Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint12.position, roomSpawnPoint12.rotation);
}
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint12.position, roomSpawnPoint12.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint12.position, roomSpawnPoint12.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room12Spawned = true;
        }

        if (room12Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint13.position, roomSpawnPoint13.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint13.position, roomSpawnPoint13.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint13.position, roomSpawnPoint13.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room13Spawned = true;
        }

        if (room13Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint14.position, roomSpawnPoint14.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint14.position, roomSpawnPoint14.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint14.position, roomSpawnPoint14.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room14Spawned = true;
        }

        if (room14Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint15.position, roomSpawnPoint15.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint15.position, roomSpawnPoint15.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint15.position, roomSpawnPoint15.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room15Spawned = true;
        }

        if (room15Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint16.position, roomSpawnPoint16.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint16.position, roomSpawnPoint16.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint16.position, roomSpawnPoint16.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room16Spawned = true;
        }

        if (room16Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint17.position, roomSpawnPoint17.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint17.position, roomSpawnPoint17.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint17.position, roomSpawnPoint17.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room17Spawned = true;
        }

        if (room17Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint18.position, roomSpawnPoint18.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint18.position, roomSpawnPoint18.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint18.position, roomSpawnPoint18.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room18Spawned = true;
        }

        if (room18Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint19.position, roomSpawnPoint19.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint19.position, roomSpawnPoint19.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint19.position, roomSpawnPoint19.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room19Spawned = true;
        }

        if (room19Spawned)
        {
        var roomToSpawn = Random.Range(0, 3);

        if (roomToSpawn == 0)
        {
            var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint20.position, roomSpawnPoint20.rotation);
        }
        if (roomToSpawn == 1)
        {
            var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint20.position, roomSpawnPoint20.rotation);
        }
        if (roomToSpawn == 2)
        {
            var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint20.position, roomSpawnPoint20.rotation);
        }

        //Debug.Log("Room Number" + roomToSpawn);

        roomSpawnActivatorTriggered = true;
        room20Spawned = true;
    }

    if (room20Spawned)
            {
                var roomToSpawn = Random.Range(0, 3);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint21.position, roomSpawnPoint21.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint21.position, roomSpawnPoint21.rotation);
                }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint21.position, roomSpawnPoint21.rotation);
                }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
                room21Spawned = true;
                noRoomsSpawned = false;
            }        

        if (room21Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint22.position, roomSpawnPoint22.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint22.position, roomSpawnPoint22.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint22.position, roomSpawnPoint22.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room22Spawned = true;
        }

        if (room22Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint23.position, roomSpawnPoint23.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint23.position, roomSpawnPoint23.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint23.position, roomSpawnPoint23.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room23Spawned = true;
        }

        if (room23Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint24.position, roomSpawnPoint24.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint24.position, roomSpawnPoint24.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint24.position, roomSpawnPoint24.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room24Spawned = true;
        }

        if (room24Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint25.position, roomSpawnPoint25.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint25.position, roomSpawnPoint25.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint25.position, roomSpawnPoint25.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room25Spawned = true;
        }

        if (room25Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint26.position, roomSpawnPoint26.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint26.position, roomSpawnPoint26.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint26.position, roomSpawnPoint26.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room26Spawned = true;
        }

        if (room26Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint27.position, roomSpawnPoint27.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint27.position, roomSpawnPoint27.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint27.position, roomSpawnPoint27.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room27Spawned = true;
        }

        if (room27Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint28.position, roomSpawnPoint28.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint28.position, roomSpawnPoint28.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint28.position, roomSpawnPoint28.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room28Spawned = true;
        }

        if (room28Spawned)
        {
            var roomToSpawn = Random.Range(0, 3);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint29.position, roomSpawnPoint29.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint29.position, roomSpawnPoint29.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint29.position, roomSpawnPoint29.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
            room29Spawned = true;
        }

        if (room29Spawned)
        {
        var roomToSpawn = Random.Range(0, 3);

        if (roomToSpawn == 0)
        {
            var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomSpawnPoint30.position, roomSpawnPoint30.rotation);
        }
        if (roomToSpawn == 1)
        {
            var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomSpawnPoint30.position, roomSpawnPoint30.rotation);
        }
        if (roomToSpawn == 2)
        {
            var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomSpawnPoint30.position, roomSpawnPoint30.rotation);
        }

        //Debug.Log("Room Number" + roomToSpawn);

        roomSpawnActivatorTriggered = true;
        room30Spawned = true;
    }

        if (room30Spawned)
        {
        var roomBossRoom = (GameObject)Instantiate(roomBossLair, roomSpawnPoint31.position, roomSpawnPoint31.rotation);


            //Debug.Log("Room Number" + roomToSpawn);
        }


    }

        void OnTriggerExit(Collider changer)
        {
            if (changer.gameObject.name == "RoomSpawnActivator")
            {
                if (roomSpawnActivatorTriggered)
                {
                    text = textBox.GetComponent<Text>();
                    text.text = "All Rooms Spawned!";
                    roomSpawnActivatorTriggered = false;
                
            }
            }
        }
    }
