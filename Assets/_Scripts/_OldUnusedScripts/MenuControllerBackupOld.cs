using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerBackupOld : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public GameObject BEVCam;
    public GameObject GameMenuCam;
    public GameObject ItemMenuCam;
    public GameObject MapMenuCam;
    public GameObject ControlsMenuCam;
    public GameObject GameSettingsMenuCam;
    public GameObject VolumeSettingsMenuCam;

    public bool mainCamMode;
    public bool firstPersonCamMode;
    public bool BEVCamMode;
    

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        mainCam = GameObject.FindWithTag("MainCamera");
        firstPersonCam = GameObject.FindWithTag("FirstPersonCamera");
        BEVCam = GameObject.FindWithTag("BEVCamera");
        GameMenuCam = GameObject.FindWithTag("GameMenuCamera");
        ItemMenuCam = GameObject.FindWithTag("ItemMenuCamera");
        MapMenuCam = GameObject.FindWithTag("MapMenuCamera");
        ControlsMenuCam = GameObject.FindWithTag("ControlsMenuCamera");
        GameSettingsMenuCam = GameObject.FindWithTag("GameSettingsCamera");
        VolumeSettingsMenuCam = GameObject.FindWithTag("VolumeSettingsCamera");

        mainCamMode = player.GetComponent<CameraControl>().mainCamMode;
        firstPersonCamMode = player.GetComponent<CameraControl>().firstPersonCamMode;
        BEVCamMode = player.GetComponent<CameraControl>().BEVCamMode;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            mainCamMode = false;
            firstPersonCamMode = false;
            BEVCamMode = false;
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            GameMenuCam.GetComponent<Camera>().enabled = true;
            GameMenuCam.GetComponent<AudioListener>().enabled = true;
            ItemMenuCam.GetComponent<Camera>().enabled = false;
            ItemMenuCam.GetComponent<AudioListener>().enabled = false;
            MapMenuCam.GetComponent<Camera>().enabled = false;
            MapMenuCam.GetComponent<AudioListener>().enabled = false;
            ControlsMenuCam.GetComponent<Camera>().enabled = false;
            ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            mainCamMode = false;
            firstPersonCamMode = false;
            BEVCamMode = false;
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            GameMenuCam.GetComponent<Camera>().enabled = false;
            GameMenuCam.GetComponent<AudioListener>().enabled = false;
            ItemMenuCam.GetComponent<Camera>().enabled = true;
            ItemMenuCam.GetComponent<AudioListener>().enabled = true;
            MapMenuCam.GetComponent<Camera>().enabled = false;
            MapMenuCam.GetComponent<AudioListener>().enabled = false;
            ControlsMenuCam.GetComponent<Camera>().enabled = false;
            ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            mainCamMode = false;
            firstPersonCamMode = false;
            BEVCamMode = false;
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            GameMenuCam.GetComponent<Camera>().enabled = false;
            GameMenuCam.GetComponent<AudioListener>().enabled = false;
            ItemMenuCam.GetComponent<Camera>().enabled = false;
            ItemMenuCam.GetComponent<AudioListener>().enabled = false;
            MapMenuCam.GetComponent<Camera>().enabled = true;
            MapMenuCam.GetComponent<AudioListener>().enabled = true;
            ControlsMenuCam.GetComponent<Camera>().enabled = false;
            ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamMode = false;
            firstPersonCamMode = false;
            BEVCamMode = false;
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            GameMenuCam.GetComponent<Camera>().enabled = false;
            GameMenuCam.GetComponent<AudioListener>().enabled = false;
            ItemMenuCam.GetComponent<Camera>().enabled = false;
            ItemMenuCam.GetComponent<AudioListener>().enabled = false;
            MapMenuCam.GetComponent<Camera>().enabled = false;
            MapMenuCam.GetComponent<AudioListener>().enabled = false;
            ControlsMenuCam.GetComponent<Camera>().enabled = true;
            ControlsMenuCam.GetComponent<AudioListener>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            closeMenus();
        }
    }

    public void closeMenus()
    {
        mainCamMode = true;
        firstPersonCamMode = false;
        BEVCamMode = false;
        mainCam.GetComponent<Camera>().enabled = true;
        mainCam.GetComponent<AudioListener>().enabled = true;
        firstPersonCam.GetComponent<Camera>().enabled = false;
        firstPersonCam.GetComponent<AudioListener>().enabled = false;
        BEVCam.GetComponent<Camera>().enabled = false;
        BEVCam.GetComponent<AudioListener>().enabled = false;
        GameMenuCam.GetComponent<Camera>().enabled = false;
        GameMenuCam.GetComponent<AudioListener>().enabled = false;
        ItemMenuCam.GetComponent<Camera>().enabled = false;
        ItemMenuCam.GetComponent<AudioListener>().enabled = false;
        MapMenuCam.GetComponent<Camera>().enabled = false;
        MapMenuCam.GetComponent<AudioListener>().enabled = false;
        ControlsMenuCam.GetComponent<Camera>().enabled = false;
        ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
    }

public void LoadByIndex(int sceneIndex)
		{ 
			SceneManager.LoadScene(sceneIndex);
		}

    public void ReturnToGame()
    {
        mainCam.GetComponent<Camera>().enabled = true;
        mainCam.GetComponent<AudioListener>().enabled = true;
        firstPersonCam.GetComponent<Camera>().enabled = false;
        firstPersonCam.GetComponent<AudioListener>().enabled = false;
        BEVCam.GetComponent<Camera>().enabled = false;
        BEVCam.GetComponent<AudioListener>().enabled = false;
        GameMenuCam.GetComponent<Camera>().enabled = false;
        GameMenuCam.GetComponent<AudioListener>().enabled = false;
        ItemMenuCam.GetComponent<Camera>().enabled = false;
        ItemMenuCam.GetComponent<AudioListener>().enabled = false;
        MapMenuCam.GetComponent<Camera>().enabled = false;
        MapMenuCam.GetComponent<AudioListener>().enabled = false;
        ControlsMenuCam.GetComponent<Camera>().enabled = false;
        ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        GameSettingsMenuCam.GetComponent<Camera>().enabled = false;
        GameSettingsMenuCam.GetComponent<AudioListener>().enabled = false;
        VolumeSettingsMenuCam.GetComponent<Camera>().enabled = false;
        VolumeSettingsMenuCam.GetComponent<AudioListener>().enabled = false;
    }
    public void ShowGameSettingsCamera()
    {
        GameMenuCam.GetComponent<Camera>().enabled = false;
        GameMenuCam.GetComponent<AudioListener>().enabled = false;
        ItemMenuCam.GetComponent<Camera>().enabled = false;
        ItemMenuCam.GetComponent<AudioListener>().enabled = false;
        MapMenuCam.GetComponent<Camera>().enabled = false;
        MapMenuCam.GetComponent<AudioListener>().enabled = false;
        ControlsMenuCam.GetComponent<Camera>().enabled = false;
        ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        GameSettingsMenuCam.GetComponent<Camera>().enabled = true;
        GameSettingsMenuCam.GetComponent<AudioListener>().enabled = true;
        VolumeSettingsMenuCam.GetComponent<Camera>().enabled = false;
        VolumeSettingsMenuCam.GetComponent<AudioListener>().enabled = false;
    }

    public void ShowVolumeSettingsCamera()
    {
        GameMenuCam.GetComponent<Camera>().enabled = false;
        GameMenuCam.GetComponent<AudioListener>().enabled = false;
        ItemMenuCam.GetComponent<Camera>().enabled = false;
        ItemMenuCam.GetComponent<AudioListener>().enabled = false;
        MapMenuCam.GetComponent<Camera>().enabled = false;
        MapMenuCam.GetComponent<AudioListener>().enabled = false;
        ControlsMenuCam.GetComponent<Camera>().enabled = false;
        ControlsMenuCam.GetComponent<AudioListener>().enabled = false;
        GameSettingsMenuCam.GetComponent<Camera>().enabled = false;
        GameSettingsMenuCam.GetComponent<AudioListener>().enabled = false;
        VolumeSettingsMenuCam.GetComponent<Camera>().enabled = true;
        VolumeSettingsMenuCam.GetComponent<AudioListener>().enabled = true;
    }

    public void ActivateItem()
    {

    }


}
