using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseSpawnerScript : MonoBehaviour
{
    public GameObject player;

    public bool isMonster = false;
    public bool isObject = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //Debug.Log("Monster" + monsterOrObject);
        var monsterOrObject = Random.Range(0, 2);

        if (monsterOrObject == 0)
        {
            isMonster = true;
            gameObject.GetComponent<MonsterSpawnScript>().enabled = true;
            gameObject.GetComponent<ObjectDecorationSpawnScript>().enabled = false;
        }
        else if (monsterOrObject == 1)
        {
            isObject = true;
            gameObject.GetComponent<MonsterSpawnScript>().enabled = false;
            gameObject.GetComponent<ObjectDecorationSpawnScript>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
        {
    }
}
