using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDungeon : MonoBehaviour
{
    /*public GameObject dungeonSweeper;
    public GameObject dungeonSweeperTarget;
    public GameObject dungeonSweeperStartLocation;*/

    public GameObject monster;
    public GameObject[] monsters;
    public GameObject room;
    public GameObject[] rooms;
    public GameObject treasureChest;
    public GameObject[] treasureChests;
    public GameObject treasureHPotion;
    public GameObject[] treasureHPotions;
    public GameObject treasureMPotion;
    public GameObject[] treasureMPotions;
    public GameObject treasureGoldPiece;
    public GameObject[] treasureGoldPieces;
    public GameObject decoration;
    public GameObject[] decorations;
    public GameObject roomSpawnPoint;
    public GameObject[] roomSpawnPoints;
    public GameObject bossRoomSpawnPoint;


    public int lightningSpeed = 100;

    public bool dungeonSweeperReachedTarget = false;

    void Start()
    {
    }

    void Update()
    {
        monsters = GameObject.FindGameObjectsWithTag("Monster");
        rooms = GameObject.FindGameObjectsWithTag("Room");
        treasureChests = GameObject.FindGameObjectsWithTag("TreasureChest");
        treasureHPotions = GameObject.FindGameObjectsWithTag("HPotion");
        treasureMPotions = GameObject.FindGameObjectsWithTag("MPotion");
        treasureGoldPieces = GameObject.FindGameObjectsWithTag("Gold");
        decorations = GameObject.FindGameObjectsWithTag("Decoration");
        roomSpawnPoints = GameObject.FindGameObjectsWithTag("RoomSpawnPoint");
        bossRoomSpawnPoint = GameObject.FindWithTag("BossRoomSpawnPoint");

        if (Input.GetKeyDown(KeyCode.P))
        {
            foreach (GameObject monster in monsters)
            {
                Destroy(monster);
            }
            foreach (GameObject room in rooms)
            {
                Destroy(room);
            }
            foreach (GameObject treasureChest in treasureChests)
            {
                Destroy(treasureChest);
            }
            foreach (GameObject treasureHPotion in treasureHPotions)
            {
                Destroy(treasureHPotion);
            }
            foreach (GameObject treasureMPotion in treasureMPotions)
            {
                Destroy(treasureMPotion);
            }
            foreach (GameObject treasureGoldPiece in treasureGoldPieces)
            {
                Destroy(treasureGoldPiece);
            }
            foreach (GameObject decoration in decorations)
            {
                Destroy(decoration);
            }
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            foreach (GameObject roomSpawnPoint in roomSpawnPoints)
            {
                roomSpawnPoint.GetComponent<RoomSpawnScript>().spawnRooms();
            }
            bossRoomSpawnPoint.GetComponent<BossMonsterSpawnScript>().spawnBossMonster();
        }
    }
    }
