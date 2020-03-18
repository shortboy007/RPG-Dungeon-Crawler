using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCam;
    public GameObject firstPersonCam;
    public GameObject BEVCam;

    public GameObject head;

    public bool mainCamMode = false;
    public bool firstPersonCamMode = false;
    //public bool thirdPersonCamMode = false;
    public bool BEVCamMode = false;


    // Start is called before the first frame update
    void Start()
    {
        mainCamMode = true;

        player = GameObject.FindWithTag("Player");
        head = GameObject.FindWithTag("PlayerHead");
        mainCam = GameObject.FindWithTag("MainCamera");
        firstPersonCam = GameObject.FindWithTag("FirstPersonCamera");
        BEVCam = GameObject.FindWithTag("BEVCamera");
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
            head.SetActive(true);
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
            head.SetActive(false);
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
            head.SetActive(true);
            //BEVCam.transform.Translate(translateH, 0, 0);
            BEVCam.transform.Translate(0, 0, translateV);
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
