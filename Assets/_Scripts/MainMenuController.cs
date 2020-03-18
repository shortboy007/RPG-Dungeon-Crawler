using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject player;

    public GameObject ControlsMenuCanvas;
    public GameObject ObjectivesMenuCanvas;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        ControlsMenuCanvas = GameObject.FindWithTag("ControlsMenuCanvas");
        ObjectivesMenuCanvas = GameObject.FindWithTag("ObjectivesMenuCanvas");

    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToGame();
        }
    }
    public void LoadByIndex(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ReturnToGame()
    {
        ControlsMenuCanvas.GetComponent<Canvas>().enabled = false;
        ObjectivesMenuCanvas.GetComponent<Canvas>().enabled = false;
    }

    public void ShowControlsMenuCanvas()
    {
        ReturnToGame();
        ControlsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowObjectivesMenuCanvas()
    {
        ReturnToGame();
        ObjectivesMenuCanvas.GetComponent<Canvas>().enabled = true;       
    }
}

