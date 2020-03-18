using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueHandlerScript : MonoBehaviour
{
    public GameObject player;

    public GameObject thisBody;

    public string dialogue1;

    public string dialogue2;

    public string dialogue3;

    public string dialogue4;

    public string dialogue5;

    public string dialogue6;

    public GameObject thoughtBubbleCanvas;

    public GameObject thoughtBubbleTextBox;
    public Text thoughtBubbleText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        thisBody = GameObject.FindWithTag("ThisBody");
    }

    void OnTriggerEnter(Collider Player)
    {        
        if (Player.gameObject.tag == "Player" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            seePlayerDialogueChoose();
            thoughtBubbleCanvas.GetComponent<Canvas>().enabled = true;
        }

        if (Player.gameObject.tag == "Player" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            seePlayerWeaponDialogueChoose();
            thoughtBubbleCanvas.GetComponent<Canvas>().enabled = true;
        }
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            seePlayerDialogueChoose();
        }

        if (Player.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.E) && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            seePlayerDialogueChoose();
        }
    }
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            thoughtBubbleCanvas.GetComponent<Canvas>().enabled = false;
        }
    }

    void seePlayerDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue1;
        }
        else if (dialogueOptionToSay == 1)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue2;
        }
        else if (dialogueOptionToSay == 2)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue3;
        }
    }

    void seePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue4;
        }
        else if (dialogueOptionToSay == 1)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue5;
        }
        else if (dialogueOptionToSay == 2)
        {
            thoughtBubbleText = thoughtBubbleTextBox.GetComponent<Text>();
            thoughtBubbleText.text = " " + dialogue6;
        }
    }

}