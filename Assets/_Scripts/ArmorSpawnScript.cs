using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmorSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject leatherArmor;
    public GameObject ironArmor;
    public GameObject steelArmor;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var objectToSpawn = Random.Range(0, 3);

        if (objectToSpawn == 0)
        {
            var leatherArmorSpawned = (GameObject)Instantiate(leatherArmor, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var ironArmorSpawned = (GameObject)Instantiate(ironArmor, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var steelArmorSpawned = (GameObject)Instantiate(steelArmor, transform.position, transform.rotation);
        }

        //Debug.Log("Monster" + objectToSpawn);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
