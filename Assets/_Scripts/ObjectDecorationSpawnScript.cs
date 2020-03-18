using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectDecorationSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject chair;
    public GameObject table;
    public GameObject chest;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var objectToSpawn = Random.Range(0, 6);

        if (objectToSpawn == 0)
        {
            var chairSpawned = (GameObject)Instantiate(chair, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var tableSpawned = (GameObject)Instantiate(table, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var chestSpawned = (GameObject)Instantiate(chest, transform.position, transform.rotation);
        }

        //Debug.Log("Monster" + objectToSpawn);


    }

    // Update is called once per frame
    void Update()
    {

    }
}
