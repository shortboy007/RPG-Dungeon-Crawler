using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    WeaponSelectHandlerV3 weaponSelectHandlerV3;

    public GameObject player;
    public GameObject thisBody;
    public GameObject GameMenuCanvas;
    public GameObject ItemMenuCanvas;
    public GameObject MapMenuCanvas;
    public GameObject ControlsMenuCanvas;
    public GameObject ObjectivesMenuCanvas;
    public GameObject StatsMenuCanvas;
    public GameObject GameSettingsMenuCanvas;
    public GameObject VolumeSettingsMenuCanvas;
    public GameObject MusicSettingsMenuCanvas;
    public GameObject AmbientSettingsMenuCanvas;
    public GameObject VoiceSettingsMenuCanvas;
    public GameObject FootstepsSettingsMenuCanvas;

    public Transform town1;
    public Transform town2;
    public Transform town3;
    public Transform town4;
    public Transform town5;
    public Transform pD;
    public Transform fD;
    public Transform iD;
    public Transform sD;
    public Transform dD;
    public Transform dT;


    public bool mainCanvasMode;
    public bool firstPersonCanvasMode;
    public bool BEVCanvasMode;
    

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        GameMenuCanvas = GameObject.FindWithTag("GameMenuCanvas");
        ItemMenuCanvas = GameObject.FindWithTag("ItemMenuCanvas");
        MapMenuCanvas = GameObject.FindWithTag("MapMenuCanvas");
        ControlsMenuCanvas = GameObject.FindWithTag("ControlsMenuCanvas");
        ObjectivesMenuCanvas = GameObject.FindWithTag("ObjectivesMenuCanvas");
        StatsMenuCanvas = GameObject.FindWithTag("StatsMenuCanvas");
        GameSettingsMenuCanvas = GameObject.FindWithTag("GameSettingsCanvas");
        VolumeSettingsMenuCanvas = GameObject.FindWithTag("VolumeSettingsCanvas");
        MusicSettingsMenuCanvas = GameObject.FindWithTag("MusicSettingsMenuCanvas");
        AmbientSettingsMenuCanvas = GameObject.FindWithTag("AmbientSettingsMenuCanvas");
        VoiceSettingsMenuCanvas = GameObject.FindWithTag("VoiceSettingsMenuCanvas");
        FootstepsSettingsMenuCanvas = GameObject.FindWithTag("FootstepsSettingsMenuCanvas");
    }

    public void Update()
    {
        thisBody = GameObject.FindWithTag("ThisBody");

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ReturnToGame();
            Time.timeScale = 0;
            GameMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        /*if (Input.GetKeyDown(KeyCode.I))
        {
            ReturnToGame();
            ItemMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            ReturnToGame();
            MapMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            ReturnToGame();
            ControlsMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            ReturnToGame();
            ObjectivesMenuCanvas.GetComponent<Canvas>().enabled = true;
        }*/
    }
public void LoadByIndex(int sceneIndex)
		{ 
			SceneManager.LoadScene(sceneIndex);
		}

    public void ResetStats()
    {
        PlayerStatHandler.PlayerHealth = 100;

        PlayerStatHandler.PlayerMagic = 100;

        PlayerStatHandler.HPotionCount = 5;

        PlayerStatHandler.MPotionCount = 5;

        PlayerStatHandler.ExperienceCount = 0;

        PlayerStatHandler.MonstersKilled = 0;

        PlayerStatHandler.BossMonstersKilled = 0;

        PlayerStatHandler.PeopleKilled = 0;
}

    public void ReturnToGame()
    {
        GameMenuCanvas.GetComponent<Canvas>().enabled = false;
        ItemMenuCanvas.GetComponent<Canvas>().enabled = false;
        MapMenuCanvas.GetComponent<Canvas>().enabled = false;
        ControlsMenuCanvas.GetComponent<Canvas>().enabled = false;
        ObjectivesMenuCanvas.GetComponent<Canvas>().enabled = false;
        StatsMenuCanvas.GetComponent<Canvas>().enabled = false;
        GameSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;
        MusicSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;
        AmbientSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;
        VoiceSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;
        FootstepsSettingsMenuCanvas.GetComponent<Canvas>().enabled = false;        
    }

    public void ResetTimeScale()
    {
        Time.timeScale = 1;
    }

    public void ShowGameMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        GameMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowItemMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        ItemMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowMapMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        MapMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowControlsMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        ControlsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowObjectivesMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        ObjectivesMenuCanvas.GetComponent<Canvas>().enabled = true;
    }
    public void ShowStatsMenuCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        StatsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowGameSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        GameSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowVolumeSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowMusicSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        MusicSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowAmbientSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        AmbientSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowVoiceSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        VoiceSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowFootstepsSettingsCanvas()
    {
        ReturnToGame();
        Time.timeScale = 0;
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        FootstepsSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void TakePlayerToTown1()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = town1.transform.position;
    }

    public void TakePlayerToTown2()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = town2.transform.position;
    }

    public void TakePlayerToTown3()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = town3.transform.position;
    }

    public void TakePlayerToTown4()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = town4.transform.position;
    }

    public void TakePlayerToTown5()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = town5.transform.position;
    }

    public void TakePlayerToPracticeDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = pD.transform.position;
    }

    public void TakePlayerToFortDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = fD.transform.position;
    }

    public void TakePlayerToIceDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = iD.transform.position;
    }

    public void TakePlayerToStoneDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = sD.transform.position;
    }

    public void TakePlayerToDesertDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = dD.transform.position;
    }

    public void TakePlayerToDarkTowerDungeon()
    {
        ReturnToGame();
        Time.timeScale = 1;
        player.transform.position = dT.transform.position;
    }

    public void equipWeaponModeChange()
    {
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedWoodWeapons = false;
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedIronWeapons = false;
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedSteelWeapons = false;
    }

    public void equipArmorModeChange()
    {
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedLeatherArmor = false;
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedIronArmor = false;
        thisBody.GetComponent<WeaponSelectHandlerV3>().equippedSteelArmor = false;
    }

    public void EquipWoodWeaponsSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveWoodWeapons == true && thisBody != null)
        {
            equipWeaponModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipWeapons();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipShield();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedWoodWeapons = true;
        }
    }
    public void EquipIronWeaponsSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveIronWeapons == true && thisBody != null)
        {
            equipWeaponModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipWeapons();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipShield();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedIronWeapons = true;
        }
    }
    public void EquipSteelWeaponsSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveSteelWeapons == true && thisBody != null)
        {
            equipWeaponModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipWeapons();
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipShield();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedSteelWeapons = true;
        }
    }

    public void EquipLeatherArmorSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveLeatherArmor == true && thisBody != null)
        {
            equipArmorModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedLeatherArmor = true;
        }
    }

    public void EquipIronArmorSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveIronArmor == true && thisBody != null)
        {
            equipArmorModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedIronArmor = true;
        }
    }

    public void EquipSteelArmorSet()
    {
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().haveSteelArmor == true && thisBody != null)
        {
            equipArmorModeChange();
            thisBody.GetComponent<WeaponSelectHandlerV3>().equippedSteelArmor = true;
        }
    }

    public void UnequipAllWeapons()
    {
        equipWeaponModeChange();
        thisBody.GetComponent<WeaponSelectHandlerV3>().unequipWeapons();
        thisBody.GetComponent<WeaponSelectHandlerV3>().unequipShield();
        thisBody.GetComponent<WeaponSelectHandlerV3>().noWeapon = true;
    }
    public void UnequipAllArmor()
    {
        equipArmorModeChange();

        thisBody.GetComponent<WeaponSelectHandlerV3>().noArmor = true;
    }

    public void ActivateItem()
    {

    }


}
