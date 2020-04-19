using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSpawnScriptOld : MonoBehaviour
{
    public GameObject player;

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
    public Transform rOPRoomSpawnPoint;
    public Transform rOPSRRoomSpawnPoint;
    public Transform rOPSLRoomSpawnPoint;
    public Transform rFPRoomSpawnPoint;
    public Transform rFPRoomSpawnPoint2;
    public Transform rFPRoomSpawnPoint3;
    public Transform rTRRoomSpawnPoint;
    public Transform rTLRoomSpawnPoint;
    public Transform rHPRoomSpawnPoint;
    public Transform rTSFRRoomSpawnPoint;
    public Transform rTSFLRoomSpawnPoint;
    public Transform roomActivatorPoint;

    public GameObject textBox;
    public Text text;

    public bool roomSpawnActivatorTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        //roomOnePath = GameObject.FindWithTag("RoomOnePath");

        roomSpawnPoint = GameObject.FindWithTag("RoomSpawnPoint").transform;

        /*  rOPRoomSpawnPoint = GameObject.FindWithTag("ROPRoomSpawnPoint").transform;
            rOPSRRoomSpawnPoint = GameObject.FindWithTag("ROPSRRoomSpawnPoint").transform;
            rOPSLRoomSpawnPoint = GameObject.FindWithTag("ROPSLRoomSpawnPoint").transform;
            rFPRoomSpawnPoint = GameObject.FindWithTag("RFPRoomSpawnPoint").transform;
            rFPRoomSpawnPoint2 = GameObject.FindWithTag("RFPRoomSpawnPoint2").transform;
            rFPRoomSpawnPoint3 = GameObject.FindWithTag("RFPRoomSpawnPoint3").transform;
            rTRRoomSpawnPoint = GameObject.FindWithTag("RTRRoomSpawnPoint").transform;
            rTLRoomSpawnPoint = GameObject.FindWithTag("RTLRoomSpawnPoint").transform;
            rHPRoomSpawnPoint = GameObject.FindWithTag("RHPRoomSpawnPoint").transform;
            rTSFRRoomSpawnPoint = GameObject.FindWithTag("RTSFRRoomSpawnPoint").transform;
            rTSFLRoomSpawnPoint = GameObject.FindWithTag("RTSFLRoomSpawnPoint").transform;
            */
        //roomActivatorPoint = GameObject.FindWithTag("RoomSpawnActivator").transform;

        textBox = GameObject.FindWithTag("NotificationText");


    }

    // Update is called once per frame
    void Update()
    {
    /*roomHallwayPath;
    roomOnePath;
    roomOnePathSidewaysRight;
    roomOnePathSidewaysLeft;
    roomFourPaths;
    roomTurnLeft;
    roomTurnRight;
    roomTurnStraightFromLeft;
    roomTurnStraightFromRight;*/

        if(roomHallwayPath != null || roomOnePath != null || roomOnePathSidewaysRight != null || roomOnePathSidewaysLeft != null || roomFourPaths != null || roomTurnLeft != null ||  roomTurnRight != null || roomTurnStraightFromLeft != null || roomTurnStraightFromRight != null)
        {
        setSpawnPointTag();
        }

        
    }

    void setSpawnPointTag()
    {
        /*rOPRoomSpawnPoint = transform.Find("RoomOnePath/ROPRoomSpawnPoint");
        rOPSRRoomSpawnPoint = transform.Find("RoomOnePathSidewaysRight/ROPRoomSpawnPoint");
        rOPSLRoomSpawnPoint = transform.Find("RoomOnePathSidewaysLeft/ROPRoomSpawnPoint");
        rFPRoomSpawnPoint = transform.Find("RoomFourPaths/RFPRoomSpawnPoint");
        rFPRoomSpawnPoint2 = transform.Find("RoomFourPaths/RFPRoomSpawnPoint2");
        rFPRoomSpawnPoint3 = transform.Find("RoomFourPaths/RFPRoomSpawnPoint3");
        rTRRoomSpawnPoint = transform.Find("RoomTurnRight/RTRRoomSpawnPoint");
        rTLRoomSpawnPoint = transform.Find("RoomTurnLeft/RTLRoomSpawnPoint");
        rHPRoomSpawnPoint = transform.Find("RoomroomHallwayPath/RHPRoomSpawnPoint");
        rTSFRRoomSpawnPoint = transform.Find("RoomTurnStraightFromRight/RTSFRRoomSpawnPoint");
        rTSFLRoomSpawnPoint = transform.Find("RoomTurnStraightFromLeft/RTSFLRoomSpawnPoint");


        rOPRoomSpawnPoint = GameObject.FindWithTag("ROPRoomSpawnPoint").transform;
        rOPSRRoomSpawnPoint = GameObject.FindWithTag("ROPSRRoomSpawnPoint").transform;
        rOPSLRoomSpawnPoint = GameObject.FindWithTag("ROPSLRoomSpawnPoint").transform;
        rFPRoomSpawnPoint = GameObject.FindWithTag("RFPRoomSpawnPoint").transform;
        rFPRoomSpawnPoint2 = GameObject.FindWithTag("RFPRoomSpawnPoint2").transform;
        rFPRoomSpawnPoint3 = GameObject.FindWithTag("RFPRoomSpawnPoint3").transform;
        rTRRoomSpawnPoint = GameObject.FindWithTag("RTRRoomSpawnPoint").transform;
        rTLRoomSpawnPoint = GameObject.FindWithTag("RTLRoomSpawnPoint").transform;
        rHPRoomSpawnPoint = GameObject.FindWithTag("RHPRoomSpawnPoint").transform;
        rTSFRRoomSpawnPoint = GameObject.FindWithTag("RTSFRRoomSpawnPoint").transform;
        rTSFLRoomSpawnPoint = GameObject.FindWithTag("RTSFLRoomSpawnPoint").transform;*/
    }

    void OnTriggerEnter(Collider changer)
    {
        if (changer.gameObject.name == "RoomSpawnActivator")
        {
            var roomToSpawn = 0;

            //var roomToSpawn = Random.Range(0, 5);

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
            if (roomToSpawn == 3)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomSpawnPoint.position, roomSpawnPoint.rotation);
            }
            if (roomToSpawn == 4)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomSpawnPoint.position, roomSpawnPoint.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "ROPRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 5);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, rOPRoomSpawnPoint.position, rOPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, rOPRoomSpawnPoint.position, rOPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, rOPRoomSpawnPoint.position, rOPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 3)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, rOPRoomSpawnPoint.position, rOPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 4)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, rOPRoomSpawnPoint.position, rOPRoomSpawnPoint.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "RFPRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 9);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, rFPRoomSpawnPoint.position, rFPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, rFPRoomSpawnPoint.position, rFPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, rFPRoomSpawnPoint.position, rFPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 3)
            {
                var roomFourPathsSpawned2 = (GameObject)Instantiate(roomFourPaths, rFPRoomSpawnPoint2.position, rFPRoomSpawnPoint2.rotation);
            }
            if (roomToSpawn == 4)
            {
                var roomFourPathsSpawned3 = (GameObject)Instantiate(roomFourPaths, rFPRoomSpawnPoint3.position, rFPRoomSpawnPoint3.rotation);
            }
            if (roomToSpawn == 5)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, rFPRoomSpawnPoint.position, rFPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 6)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, rFPRoomSpawnPoint.position, rFPRoomSpawnPoint.rotation);
            }
            if (roomToSpawn == 7)
            {
                var roomTurnStraightFromRightSpawned = (GameObject)Instantiate(roomTurnStraightFromRight, rFPRoomSpawnPoint2.position, rFPRoomSpawnPoint2.rotation);
            }
            if (roomToSpawn == 8)
            {
                var roomTurnStraightFromLeftSpawned = (GameObject)Instantiate(roomTurnStraightFromLeft, rFPRoomSpawnPoint3.position, rFPRoomSpawnPoint3.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "RTRRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 1);

            if (roomToSpawn == 0)
            {
                var roomOnePathSidewaysRightSpawned = (GameObject)Instantiate(roomOnePathSidewaysRight, rTRRoomSpawnPoint.position, rTRRoomSpawnPoint.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }


        if (changer.gameObject.name == "RTLRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 1);

            if (roomToSpawn == 0)
            {
                var roomOnePathSidewaysLeftSpawned = (GameObject)Instantiate(roomOnePathSidewaysLeft, rTLRoomSpawnPoint.position, rTLRoomSpawnPoint.rotation);


                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }
        }

            if (changer.gameObject.name == "RHPRoomSpawnActivator")
            {

            var roomToSpawn = 0;

                //var roomToSpawn = Random.Range(0, 5);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, rHPRoomSpawnPoint.position, rHPRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, rHPRoomSpawnPoint.position, rHPRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, rHPRoomSpawnPoint.position, rHPRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, rHPRoomSpawnPoint.position, rHPRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, rHPRoomSpawnPoint.position, rHPRoomSpawnPoint.rotation);
                }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "RTSFRRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 5);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, rTSFRRoomSpawnPoint.position, rTSFRRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, rTSFRRoomSpawnPoint.position, rTSFRRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, rTSFRRoomSpawnPoint.position, rTSFRRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, rTSFRRoomSpawnPoint.position, rTSFRRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, rTSFRRoomSpawnPoint.position, rTSFRRoomSpawnPoint.rotation);
                }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "RTSFLRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 5);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, rTSFLRoomSpawnPoint.position, rTSFLRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, rTSFLRoomSpawnPoint.position, rTSFLRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, rTSFLRoomSpawnPoint.position, rTSFLRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, rTSFLRoomSpawnPoint.position, rTSFLRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, rTSFLRoomSpawnPoint.position, rTSFLRoomSpawnPoint.rotation);
                }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "ROPSRRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 2);

                if (roomToSpawn == 0)
                {
                    var roomOnePathSidewaysRightSpawned = (GameObject)Instantiate(roomOnePathSidewaysRight, rOPSRRoomSpawnPoint.position, rOPSRRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomTurnStraightFromRightSpawned = (GameObject)Instantiate(roomTurnStraightFromRight, rOPSRRoomSpawnPoint.position, rOPSRRoomSpawnPoint.rotation);
                }
            }

            if (changer.gameObject.name == "ROPSLRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 2);

                if (roomToSpawn == 0)
                {
                    var roomOnePathSidewaysLeftSpawned = (GameObject)Instantiate(roomOnePathSidewaysLeft, rOPSLRoomSpawnPoint.position, rOPSLRoomSpawnPoint.rotation);
                }
                if (roomToSpawn == 1)
                {
                    var roomTurnStraightFromLeftSpawned = (GameObject)Instantiate(roomTurnStraightFromLeft, rOPSLRoomSpawnPoint.position, rOPSLRoomSpawnPoint.rotation);
                }
            }

        }

        void OnTriggerExit(Collider changer)
        {
            if (changer.gameObject.name == "RoomSpawnActivator")
            {
                if (roomSpawnActivatorTriggered)
                {
                    text = textBox.GetComponent<Text>();
                    text.text = "First Room Spawned!";
                    roomSpawnActivatorTriggered = false;
                }
            }
        }
    }
