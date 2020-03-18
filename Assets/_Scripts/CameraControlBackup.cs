using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlBackup : MonoBehaviour
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

    public GameObject head;

    public bool mainCamMode = false;
    public bool firstPersonCamMode = false;
    //public bool thirdPersonCamMode = false;
    public bool BEVCamMode = false;
    public bool menuCamMode = false;


    // Start is called before the first frame update
    void Start()
    {
        mainCamMode = true;

        player = GameObject.FindWithTag("Player");
        head = GameObject.FindWithTag("PlayerHead");
        mainCam = GameObject.FindWithTag("MainCamera");
        firstPersonCam = GameObject.FindWithTag("FirstPersonCamera");
        BEVCam = GameObject.FindWithTag("BEVCamera");
        GameMenuCam = GameObject.FindWithTag("GameMenuCamera");
        ItemMenuCam = GameObject.FindWithTag("ItemMenuCamera");
        MapMenuCam = GameObject.FindWithTag("MapMenuCamera");
        ControlsMenuCam = GameObject.FindWithTag("ControlsMenuCamera");
        GameSettingsMenuCam = GameObject.FindWithTag("GameSettingsCamera");
        VolumeSettingsMenuCam = GameObject.FindWithTag("VolumeSettingsCamera");
    }
    // Update is called once per frame
    void Update()
    {
        //var rotateH = Input.GetAxis("CamControlH") * Time.deltaTime * 150.0f;
        var rotateV = Input.GetAxis("CamControlV") * Time.deltaTime * 150.0f;
        var translateH = Input.GetAxis("CamControlH") * Time.deltaTime * 10.0f;
        var translateV = Input.GetAxis("CamControlV") * Time.deltaTime * 10.0f;

        //transform.Rotate(0, rotate, 0);
        //transform.Rotate(0, rotateH, 0);



        if (mainCamMode)
        {
            mainCam.GetComponent<Camera>().enabled = true;
            mainCam.GetComponent<AudioListener>().enabled = true;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            head.GetComponent<MeshRenderer>().enabled = true;
            mainCam.transform.Translate(0, 0, translateV);

        }
        if (firstPersonCamMode)
        {
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = true;
            firstPersonCam.GetComponent<AudioListener>().enabled = true;
            BEVCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<AudioListener>().enabled = false;
            head.GetComponent<MeshRenderer>().enabled = false;
            firstPersonCam.transform.Rotate(rotateV, 0, 0);
        }
        if (BEVCamMode)
        {
            mainCam.GetComponent<Camera>().enabled = false;
            mainCam.GetComponent<AudioListener>().enabled = false;
            firstPersonCam.GetComponent<Camera>().enabled = false;
            firstPersonCam.GetComponent<AudioListener>().enabled = false;
            //thirdPersonCam.GetComponent<Camera>().enabled = false;
            BEVCam.GetComponent<Camera>().enabled = true;
            BEVCam.GetComponent<AudioListener>().enabled = true;
            head.GetComponent<MeshRenderer>().enabled = true;
            //BEVCam.transform.Translate(translateH, 0, 0);
            BEVCam.transform.Translate(0, 0, translateV);
        }
        if (menuCamMode)
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
            head.GetComponent<MeshRenderer>().enabled = false;
        }

        if (Input.GetKeyDown(KeyCode.V))
        {

            if (mainCamMode)
            {
                mainCamMode = false;
                firstPersonCamMode = true;
                BEVCamMode = false;
            }
            else if (firstPersonCamMode)
            {
                mainCamMode = false;
                firstPersonCamMode = false;
                BEVCamMode = true;
            }
            else if (BEVCamMode)
            {
                mainCamMode = true;
                firstPersonCamMode = false;
                BEVCamMode = false;
            }
        }
    }
}
