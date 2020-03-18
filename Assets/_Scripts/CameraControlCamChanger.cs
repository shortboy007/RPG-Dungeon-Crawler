using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlCamChanger : MonoBehaviour
{
    public GameObject player;

    public GameObject thisBody;

    public GameObject characterCustomizer;

    public GameObject mainCam;
    public GameObject mainUI;
    public GameObject menuUI;
    public GameObject CharacterCustomizerPlatform;
    public GameObject CharacterCustomizerPlatformCam;
    public GameObject CharacterCustomizerPlatformCanvas;

    public bool mainCamMode = false;
    public bool CharacterCustomizerPlatformCamMode = false;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        CharacterCustomizerPlatformCamMode = true;
    }
    // Update is called once per frame
    void Update()
    {
        
        thisBody = GameObject.FindWithTag("ThisBody");

        if (mainCamMode && thisBody != null)
        {
            
            mainCam.SetActive(true);
            mainUI.SetActive(true);
            menuUI.SetActive(true);
            CharacterCustomizerPlatform.SetActive(false);
            CharacterCustomizerPlatformCanvas.GetComponent<Canvas>().enabled = false;
            CharacterCustomizerPlatformCam.SetActive(false);
            player.GetComponent<PlayerMoveAnims>().enabled = true;
            player.GetComponent<PlayerStatHandler>().enabled = true;
            thisBody.GetComponent<WeaponSelectHandlerV3>().enabled = true;
            player.GetComponent<ResetDungeon>().enabled = true;
            player.GetComponent<NotificationHandlerScript>().enabled = true;

        }
        if (CharacterCustomizerPlatformCamMode)
        {
            mainCam.SetActive(false);
            mainUI.SetActive(false);
            menuUI.SetActive(false);
            CharacterCustomizerPlatform.SetActive(true);
            CharacterCustomizerPlatformCanvas.SetActive(true);
            CharacterCustomizerPlatformCam.SetActive(true);
            player.GetComponent<PlayerMoveAnims>().enabled = false;
            player.GetComponent<PlayerStatHandler>().enabled = false;
            thisBody.GetComponent<WeaponSelectHandlerV3>().enabled = false;
            player.GetComponent<ResetDungeon>().enabled = false;
            player.GetComponent<NotificationHandlerScript>().enabled = false;
        }
    }
    /*void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "CharacterCustomizerPlatform")
        {
            if (mainCamMode)
            {
                mainCamMode = false;
                CharacterCustomizerPlatformCamMode = true;
            }
        }
    }*/
    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "CharacterCustomizerPlatform")
        {
            
            if (CharacterCustomizerPlatformCamMode)
            {
                mainCamMode = true;
                CharacterCustomizerPlatformCamMode = false;
            }
        }
    }
}
