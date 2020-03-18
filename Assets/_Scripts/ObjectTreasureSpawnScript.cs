using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTreasureSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject gold;
    public GameObject hPotion;
    public GameObject mPotion;
    public GameObject wArrowPickup;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var objectToSpawn = Random.Range(0, 4);

        if (objectToSpawn == 0)
        {
           
            var goldToSpawn = Random.Range(0, 3);
            if(goldToSpawn == 0)
            {
                var goldSpawned = (GameObject)Instantiate(gold, transform.position, transform.rotation);
            }
            else if (goldToSpawn == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    Instantiate(gold, transform.position, Quaternion.identity);
                }
            }
            else if (goldToSpawn == 2)
            {
                for (int i = 0; i < 20; i++)
                {
                    Instantiate(gold, transform.position, Quaternion.identity);
                }
            }
        }
        else if (objectToSpawn == 1)
        {
            var hPotionSpawned = (GameObject)Instantiate(hPotion, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var mPotionSpawned = (GameObject)Instantiate(mPotion, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 3)
        {
            var wArrowsSpawned = (GameObject)Instantiate(wArrowPickup, transform.position, transform.rotation);
        }

        //Debug.Log("Monster" + objectToSpawn);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
