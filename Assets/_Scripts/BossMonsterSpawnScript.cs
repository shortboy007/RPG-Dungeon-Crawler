using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossMonsterSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject goblin;
    public GameObject orc;
    public GameObject ogre;
    public GameObject bandit;
    public GameObject snake;
    public GameObject spider;
    public GameObject wolf;
    public GameObject imp;
    public GameObject skeleton;
    public GameObject mage;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        spawnBossMonster();

        //Debug.Log("Monster" + monsterToSpawn);
    }

    // Update is called once per frame
    void Update()
        {

        }    

    public void spawnBossMonster()
    {
        var monsterToSpawn = Random.Range(0, 10);

        if (monsterToSpawn == 0)
        {
            var goblinSpawned = (GameObject)Instantiate(goblin, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 1)
        {
            var orcSpawned = (GameObject)Instantiate(orc, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 2)
        {
            var ogreSpawned = (GameObject)Instantiate(ogre, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 3)
        {
            var banditSpawned = (GameObject)Instantiate(bandit, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 4)
        {
            var snakeSpawned = (GameObject)Instantiate(snake, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 5)
        {
            var spiderSpawned = (GameObject)Instantiate(spider, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 6)
        {
            var wolfSpawned = (GameObject)Instantiate(wolf, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 7)
        {
            var impSpawned = (GameObject)Instantiate(imp, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 8)
        {
            var skeletonSpawned = (GameObject)Instantiate(skeleton, transform.position, transform.rotation);
        }
        else if (monsterToSpawn == 9)
        {
            var mageSpawned = (GameObject)Instantiate(mage, transform.position, transform.rotation);
        }
    }
    }
