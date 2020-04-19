using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DungeonNumberOfSpawnsScript : MonoBehaviour
{
    public GameObject player;

    public GameObject oneMonster;
    public GameObject twoMonster;
    public GameObject threeMonster;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var monsterToSpawn = Random.Range(0, 3);

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

        //Debug.Log("Monster" + monsterToSpawn);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
