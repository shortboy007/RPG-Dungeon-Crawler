using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeleportScript : MonoBehaviour
{
    public GameObject player;

    public GameObject targetSpawn;

    public GameObject textBox;
    public Text text;

    public bool playerDetected = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        textBox = GameObject.FindWithTag("NotificationText");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Debug.Log("EnterCollision");
        }
    }

        void OnTriggerStay(Collider Player)
        {
            if (Player.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.E)))
                {
                    player.transform.position = targetSpawn.transform.position;
                    player.transform.rotation = targetSpawn.transform.rotation;
                    Debug.Log("Teleport Successful!");
                }
                //text = textBox.GetComponent<Text>();
                //text.text = "Press E to go to " + targetSpawn + ".";
        }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Debug.Log("LeaveCollision!");
        }
    }


}
