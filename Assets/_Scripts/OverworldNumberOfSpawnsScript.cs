using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverworldNumberOfSpawnsScript : MonoBehaviour
{
    public GameObject player;

    public GameObject oneMonster;
    public GameObject twoMonster;
    public GameObject threeMonster;
    public GameObject fourMonster;
    public GameObject fiveMonster;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        SpawnMonsters();
        //Debug.Log("Monster" + monsterToSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if(count == 20000)
        {
            SpawnMonsters();
        }
    }

    void SpawnMonsters()
    {
        count = 0;

        var monsterToSpawn = Random.Range(0, 4);

        if (monsterToSpawn == 0)
        {
            var oneMonsterSpawned = (GameObject)Instantiate(oneMonster, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 1)
        {
            var twoMonstersSpawned = (GameObject)Instantiate(twoMonster, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 2)
        {
            var twoMonstersOneObjectSpawned = (GameObject)Instantiate(threeMonster, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 3)
        {
            var twoMonstersSpawned = (GameObject)Instantiate(fourMonster, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 4)
        {
            var twoMonstersOneObjectSpawned = (GameObject)Instantiate(fiveMonster, transform.position, transform.rotation);
        }
    }
}
