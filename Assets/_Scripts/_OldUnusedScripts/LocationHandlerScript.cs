using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLocationHandler : MonoBehaviour
{
    public GameObject player;

    public GameObject barrier;

    public GameObject textBox;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {       
            player = GameObject.FindWithTag("Player");

            textBox = GameObject.FindWithTag("LocationText");
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.name == "TeleporterToOWPD")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Practice Dungeon.";
        }
        if (Player.gameObject.name == "TeleporterToPD")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld";
        }
        if (Player.gameObject.name == "TeleporterToOWT1")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToOWT2")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld";
        }
        if (Player.gameObject.name == "TeleporterToOWT3")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld";
        }
        if (Player.gameObject.name == "TeleporterToOWT4")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld";
        }
        if (Player.gameObject.name == "TeleporterToOWT5")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Overworld";
        }
        if (Player.gameObject.name == "TeleporterToT1")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Town 1.";
        }
        if (Player.gameObject.name == "TeleporterToT2")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Town 2.";
        }
        if (Player.gameObject.name == "TeleporterToT3")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Town 3.";
        }
        if (Player.gameObject.name == "TeleporterToT4")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Town 4.";
        }
        if (Player.gameObject.name == "TeleporterToT5")
        {
            text = textBox.GetComponent<Text>();
            text.text = "Town 5.";
        }

    }
}