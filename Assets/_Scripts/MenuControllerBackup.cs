using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControllerBackup : MonoBehaviour
{
    /*
     * WeaponSelectHandlerV2 weaponSelectHandlerV2;

    public GameObject player;
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
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            ReturnToGame();
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
        }
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

    public void ShowGameMenuCanvas()
    {
        ReturnToGame();
        GameMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowItemMenuCanvas()
    {
        ReturnToGame();
        ItemMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowMapMenuCanvas()
    {
        ReturnToGame();
        MapMenuCanvas.GetComponent<Canvas>().enabled = true;
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
    public void ShowStatsMenuCanvas()
    {
        ReturnToGame();
        StatsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowGameSettingsCanvas()
    {
        ReturnToGame();
        GameSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowVolumeSettingsCanvas()
    {
        ReturnToGame();
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowMusicSettingsCanvas()
    {
        ReturnToGame();
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        MusicSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowAmbientSettingsCanvas()
    {
        ReturnToGame();
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        AmbientSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowVoiceSettingsCanvas()
    {
        ReturnToGame();
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        VoiceSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowFootstepsSettingsCanvas()
    {
        ReturnToGame();
        VolumeSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
        FootstepsSettingsMenuCanvas.GetComponent<Canvas>().enabled = true;
    }

    public void TakePlayerToTown1()
    {
        ReturnToGame();
        player.transform.position = town1.transform.position;
    }

    public void TakePlayerToTown2()
    {
        ReturnToGame();
        player.transform.position = town2.transform.position;
    }

    public void TakePlayerToTown3()
    {
        ReturnToGame();
        player.transform.position = town3.transform.position;
    }

    public void TakePlayerToTown4()
    {
        ReturnToGame();
        player.transform.position = town4.transform.position;
    }

    public void TakePlayerToTown5()
    {
        ReturnToGame();
        player.transform.position = town5.transform.position;
    }

    public void TakePlayerToPracticeDungeon()
    {
        ReturnToGame();
        player.transform.position = pD.transform.position;
    }

    public void TakePlayerToFortDungeon()
    {
        ReturnToGame();
        player.transform.position = fD.transform.position;
    }

    public void TakePlayerToIceDungeon()
    {
        ReturnToGame();
        player.transform.position = iD.transform.position;
    }

    public void TakePlayerToStoneDungeon()
    {
        ReturnToGame();
        player.transform.position = sD.transform.position;
    }

    public void TakePlayerToDesertDungeon()
    {
        ReturnToGame();
        player.transform.position = dD.transform.position;
    }

    public void TakePlayerToDarkTowerDungeon()
    {
        ReturnToGame();
        player.transform.position = dT.transform.position;
    }

    public void equipWeaponModeChange()
    {
        player.GetComponent<WeaponSelectHandlerV2>().equippedWoodWeapons = false;
        player.GetComponent<WeaponSelectHandlerV2>().equippedIronWeapons = false;
        player.GetComponent<WeaponSelectHandlerV2>().equippedSteelWeapons = false;
    }

    public void equipArmorModeChange()
    {
        player.GetComponent<WeaponSelectHandlerV2>().equippedLeatherArmor = false;
        player.GetComponent<WeaponSelectHandlerV2>().equippedIronArmor = false;
        player.GetComponent<WeaponSelectHandlerV2>().equippedSteelArmor = false;
    }

    public void EquipWoodWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveWoodWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerV2>().unequipShield();
            player.GetComponent<WeaponSelectHandlerV2>().equippedWoodWeapons = true;
        }
    }
    public void EquipIronWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveIronWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerV2>().unequipShield();
            player.GetComponent<WeaponSelectHandlerV2>().equippedIronWeapons = true;
        }
    }
    public void EquipSteelWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveSteelWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerV2>().unequipShield();
            player.GetComponent<WeaponSelectHandlerV2>().equippedSteelWeapons = true;
        }
    }

    public void EquipLeatherArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveLeatherArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().equippedLeatherArmor = true;
        }
    }

    public void EquipIronArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveIronArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().equippedIronArmor = true;
        }
    }

    public void EquipSteelArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerV2>().haveSteelArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerV2>().equippedSteelArmor = true;
        }
    }

    public void UnequipAllWeapons()
    {
        equipWeaponModeChange();
        player.GetComponent<WeaponSelectHandlerV2>().unequipWeapons();
        player.GetComponent<WeaponSelectHandlerV2>().unequipShield();
        player.GetComponent<WeaponSelectHandlerV2>().noWeapon = true;
    }
    public void UnequipAllArmor()
    {
        equipArmorModeChange();

        player.GetComponent<WeaponSelectHandlerV2>().noArmor = true;
    }

    public void ActivateItem()
    {

    }

    */
}
