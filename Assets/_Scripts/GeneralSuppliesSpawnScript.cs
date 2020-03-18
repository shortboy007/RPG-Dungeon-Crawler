using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneralSuppliesSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject hPotion;
    public GameObject mPotion;
    public GameObject wArrowPickup;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var objectToSpawn = Random.Range(0, 3);

        if (objectToSpawn == 0)
        {
            var hPotionSpawned = (GameObject)Instantiate(hPotion, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var mPotionSpawned = (GameObject)Instantiate(mPotion, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
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
