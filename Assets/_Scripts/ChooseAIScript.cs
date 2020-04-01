using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseAIScript : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        gameObject.GetComponent<EnemyAIDungeonScript>().enabled = false;
        gameObject.GetComponent<EnemyAIMultiScriptStates>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay(Collider dungeon)
    {
        if (dungeon.gameObject.tag == "Dungeon")
        {
            gameObject.GetComponent<EnemyAIDungeonScript>().enabled = true;
            gameObject.GetComponent<EnemyAIMultiScriptStates>().enabled = false;
        }
    }

}
