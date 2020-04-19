using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomSpawnScriptVectors : MonoBehaviour
{
    public GameObject player;

    public GameObject frontGate;
    public GameObject roomHallwayPath;
    public GameObject roomOnePath;
    public GameObject roomOnePathSidewaysRight;
    public GameObject roomOnePathSidewaysLeft;
    public GameObject roomFourPaths;
    public GameObject roomTurnLeft;
    public GameObject roomTurnRight;
    public GameObject roomTurnStraightFromRight;
    public GameObject roomTurnStraightFromLeft;


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

    public GameObject textBox;
    public Text text;

    public bool roomSpawnActivatorTriggered = false;

    public Vector3 frontGateVector;
    public Vector3 roomHallwayPathVector;
    public Vector3 roomOnePathVector;
    public Vector3 roomOnePathSidewaysRightVector;
    public Vector3 roomOnePathSidewaysLeftVector;
    public Vector3 roomFourPathsFrontVector;
    public Vector3 roomFourPathsRightVector;
    public Vector3 roomFourPathsLeftVector;
    public Vector3 roomTurnRightVector;
    public Vector3 roomTurnLeftVector;
    public Vector3 roomTurnStraightFromRightVector;
    public Vector3 roomTurnStraightFromLeftVector;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        

       textBox = GameObject.FindWithTag("NotificationText");

        frontGateVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomHallwayPathVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomOnePathVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomOnePathSidewaysRightVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomOnePathSidewaysLeftVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomFourPathsFrontVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomFourPathsRightVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomFourPathsLeftVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomTurnRightVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomTurnLeftVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomTurnStraightFromRightVector = new Vector3(85.0f, -16.0f, -12.6f);
        roomTurnStraightFromLeftVector = new Vector3(85.0f, -16.0f, -12.6f);
        
    }

    // Update is called once per frame
    void Update()
    {

    }

           /* if (frontGate != null || roomHallwayPath != null || roomOnePath != null || roomOnePathSidewaysRight != null || roomOnePathSidewaysLeft != null || roomFourPaths != null || roomTurnLeft != null || roomTurnRight != null || roomTurnStraightFromLeft != null || roomTurnStraightFromRight != null)
        {
            setSpawnPointTag();
}


    }

    void setSpawnPointTag()
{
    roomSpawnPoint = GameObject.FindWithTag("ROPRoomSpawnPoint").transform;
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
    rTSFLRoomSpawnPoint = GameObject.FindWithTag("RTSFLRoomSpawnPoint").transform;
}*/



void OnTriggerEnter(Collider changer)
    {
        if (changer.gameObject.name == "RoomSpawnActivator")
        {

            var roomToSpawn = 0;

            //var roomToSpawn = Random.Range(0, 5);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, frontGate.transform.position + frontGateVector, frontGate.transform.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, frontGate.transform.position + frontGateVector, frontGate.transform.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, frontGate.transform.position + frontGateVector, frontGate.transform.rotation);
            }
            if (roomToSpawn == 3)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, frontGate.transform.position + frontGateVector, frontGate.transform.rotation);
            }
            if (roomToSpawn == 4)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, frontGate.transform.position + frontGateVector, frontGate.transform.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "ROPRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 5);

            if (roomToSpawn == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomOnePath.transform.position + roomOnePathVector, roomOnePath.transform.rotation);
            }
            if (roomToSpawn == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomOnePath.transform.position + roomOnePathVector, roomOnePath.transform.rotation);
            }
            if (roomToSpawn == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomOnePath.transform.position + roomOnePathVector, roomOnePath.transform.rotation);
            }
            if (roomToSpawn == 3)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomOnePath.transform.position + roomOnePathVector, roomOnePath.transform.rotation);
            }
            if (roomToSpawn == 4)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomOnePath.transform.position + roomOnePathVector, roomOnePath.transform.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "RFPRoomSpawnActivator")
        {

            var roomToSpawnFront = Random.Range(0, 5);

            if (roomToSpawnFront == 0)
            {
                var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomFourPaths.transform.position + roomFourPathsFrontVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnFront == 1)
            {
                var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomFourPaths.transform.position + roomFourPathsFrontVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnFront == 2)
            {
                var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomFourPaths.transform.position + roomFourPathsFrontVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnFront == 3)
            {
                var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomFourPaths.transform.position + roomFourPathsFrontVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnFront == 4)
            {
                var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomFourPaths.transform.position + roomFourPathsFrontVector, roomFourPaths.transform.rotation);
            }

            var roomToSpawnRight = Random.Range(0, 2);

            if (roomToSpawnRight == 0)
            {
                var roomFourPathsSpawned2 = (GameObject)Instantiate(roomFourPaths, roomFourPaths.transform.position + roomFourPathsRightVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnRight == 1)
            {
                var roomTurnStraightFromRightSpawned = (GameObject)Instantiate(roomTurnStraightFromRight, roomFourPaths.transform.position + roomFourPathsRightVector, roomFourPaths.transform.rotation);
            }

            var roomToSpawnLeft = Random.Range(0, 2);

            if (roomToSpawnLeft == 0)
            {
                var roomFourPathsSpawned3 = (GameObject)Instantiate(roomFourPaths, roomFourPaths.transform.position + roomFourPathsLeftVector, roomFourPaths.transform.rotation);
            }
            if (roomToSpawnLeft == 1)
            {
                var roomTurnStraightFromLeftSpawned = (GameObject)Instantiate(roomTurnStraightFromLeft, roomFourPaths.transform.position + roomFourPathsLeftVector, roomFourPaths.transform.rotation);
            }
            
            
                
           

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }

        if (changer.gameObject.name == "RTRRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 1);

            if (roomToSpawn == 0)
            {
                var roomOnePathSidewaysRightSpawned = (GameObject)Instantiate(roomOnePathSidewaysRight, roomTurnRight.transform.position + roomTurnRightVector, roomTurnRight.transform.rotation);
            }

            //Debug.Log("Room Number" + roomToSpawn);

            roomSpawnActivatorTriggered = true;
        }


        if (changer.gameObject.name == "RTLRoomSpawnActivator")
        {

            var roomToSpawn = Random.Range(0, 1);

            if (roomToSpawn == 0)
            {
                var roomOnePathSidewaysLeftSpawned = (GameObject)Instantiate(roomOnePathSidewaysLeft, roomTurnLeft.transform.position + roomTurnLeftVector, roomTurnLeft.transform.rotation);


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
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomHallwayPath.transform.position + roomHallwayPathVector, roomHallwayPath.transform.rotation);
            }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomHallwayPath.transform.position + roomHallwayPathVector, roomHallwayPath.transform.rotation);
            }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomHallwayPath.transform.position + roomHallwayPathVector, roomHallwayPath.transform.rotation);
            }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomHallwayPath.transform.position + roomHallwayPathVector, roomHallwayPath.transform.rotation);
            }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomHallwayPath.transform.position + roomHallwayPathVector, roomHallwayPath.transform.rotation);
            }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "RTSFRRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 5);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomTurnStraightFromRight.transform.position + roomTurnStraightFromRightVector, roomTurnStraightFromRight.transform.rotation);
            }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomTurnStraightFromRight.transform.position + roomTurnStraightFromRightVector, roomTurnStraightFromRight.transform.rotation);
            }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomTurnStraightFromRight.transform.position + roomTurnStraightFromRightVector, roomTurnStraightFromRight.transform.rotation);
            }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomTurnStraightFromRight.transform.position + roomTurnStraightFromRightVector, roomTurnStraightFromRight.transform.rotation);
            }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomTurnStraightFromRight.transform.position + roomTurnStraightFromRightVector, roomTurnStraightFromRight.transform.rotation);
            }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "RTSFLRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 5);

                if (roomToSpawn == 0)
                {
                    var roomHallwaySpawned = (GameObject)Instantiate(roomHallwayPath, roomTurnStraightFromLeft.transform.position + roomTurnStraightFromLeftVector, roomTurnStraightFromLeft.transform.rotation);
            }
                if (roomToSpawn == 1)
                {
                    var roomOnePathSpawned = (GameObject)Instantiate(roomOnePath, roomTurnStraightFromLeft.transform.position + roomTurnStraightFromLeftVector, roomTurnStraightFromLeft.transform.rotation);
            }
                if (roomToSpawn == 2)
                {
                    var roomFourPathsSpawned = (GameObject)Instantiate(roomFourPaths, roomTurnStraightFromLeft.transform.position + roomTurnStraightFromLeftVector, roomTurnStraightFromLeft.transform.rotation);
            }
                if (roomToSpawn == 3)
                {
                    var roomTurnLeftSpawned = (GameObject)Instantiate(roomTurnLeft, roomTurnStraightFromLeft.transform.position + roomTurnStraightFromLeftVector, roomTurnStraightFromLeft.transform.rotation);
            }
                if (roomToSpawn == 4)
                {
                    var roomTurnRightSpawned = (GameObject)Instantiate(roomTurnRight, roomTurnStraightFromLeft.transform.position + roomTurnStraightFromLeftVector, roomTurnStraightFromLeft.transform.rotation);
            }

                //Debug.Log("Room Number" + roomToSpawn);

                roomSpawnActivatorTriggered = true;
            }

            if (changer.gameObject.name == "ROPSRRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 2);

                if (roomToSpawn == 0)
                {
                    var roomOnePathSidewaysRightSpawned = (GameObject)Instantiate(roomOnePathSidewaysRight, roomOnePathSidewaysRight.transform.position + roomOnePathSidewaysRightVector, roomOnePathSidewaysRight.transform.rotation);
            }
                if (roomToSpawn == 1)
                {
                    var roomTurnStraightFromRightSpawned = (GameObject)Instantiate(roomTurnStraightFromRight, roomOnePathSidewaysRight.transform.position + roomOnePathSidewaysRightVector, roomOnePathSidewaysRight.transform.rotation);
            }
            }

            if (changer.gameObject.name == "ROPSLRoomSpawnActivator")
            {

                var roomToSpawn = Random.Range(0, 2);

                if (roomToSpawn == 0)
                {
                    var roomOnePathSidewaysLeftSpawned = (GameObject)Instantiate(roomOnePathSidewaysLeft, roomOnePathSidewaysLeft.transform.position + roomOnePathSidewaysLeftVector, roomOnePathSidewaysLeft.transform.rotation);
            }
                if (roomToSpawn == 1)
                {
                    var roomTurnStraightFromLeftSpawned = (GameObject)Instantiate(roomTurnStraightFromLeft, roomOnePathSidewaysLeft.transform.position + roomOnePathSidewaysLeftVector, roomOnePathSidewaysLeft.transform.rotation);
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
