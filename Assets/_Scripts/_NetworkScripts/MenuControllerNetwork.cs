using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public class MenuControllerNetwork : NetworkBehaviour
{
    WeaponSelectHandlerNetwork weaponSelectHandlerNetwork;

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
        if (Input.GetKeyDown(KeyCode.Q))
        {
            ReturnToGame();
            GameMenuCanvas.GetComponent<Canvas>().enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.I))
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
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ReturnToGame();
        }
    }
public void LoadByIndex(int sceneIndex)
		{ 
			SceneManager.LoadScene(sceneIndex);
		}

    public void ResetStats()
    {
        PlayerStatHandlerNetwork.PlayerHealth = 100;

        PlayerStatHandlerNetwork.PlayerMagic = 100;

        PlayerStatHandlerNetwork.HPotionCount = 5;

        PlayerStatHandlerNetwork.MPotionCount = 5;

        PlayerStatHandlerNetwork.ExperienceCount = 0;

        PlayerStatHandlerNetwork.MonstersKilled = 0;

        PlayerStatHandlerNetwork.BossMonstersKilled = 0;

        PlayerStatHandlerNetwork.PeopleKilled = 0;
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

    public void equipWeaponModeChange()
    {
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedWoodWeapons = false;
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedIronWeapons = false;
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedSteelWeapons = false;
    }

    public void equipArmorModeChange()
    {
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedLeatherArmor = false;
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedIronArmor = false;
        player.GetComponent<WeaponSelectHandlerNetwork>().equippedSteelArmor = false;
    }

    public void EquipWoodWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveWoodWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipShield();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedWoodWeapons = true;
        }
    }
    public void EquipIronWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveIronWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipShield();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedIronWeapons = true;
        }
    }
    public void EquipSteelWeaponsSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveSteelWeapons == true)
        {
            equipWeaponModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipWeapons();
            player.GetComponent<WeaponSelectHandlerNetwork>().unequipShield();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedSteelWeapons = true;
        }
    }

    public void EquipLeatherArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveLeatherArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedLeatherArmor = true;
        }
    }

    public void EquipIronArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveIronArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedIronArmor = true;
        }
    }

    public void EquipSteelArmorSet()
    {
        if (player.GetComponent<WeaponSelectHandlerNetwork>().haveSteelArmor == true)
        {
            equipArmorModeChange();
            player.GetComponent<WeaponSelectHandlerNetwork>().equippedSteelArmor = true;
        }
    }

    public void UnequipAllWeapons()
    {
        equipWeaponModeChange();
        player.GetComponent<WeaponSelectHandlerNetwork>().unequipWeapons();
        player.GetComponent<WeaponSelectHandlerNetwork>().unequipShield();
        player.GetComponent<WeaponSelectHandlerNetwork>().noWeapon = true;
    }
    public void UnequipAllArmor()
    {
        equipArmorModeChange();

        player.GetComponent<WeaponSelectHandlerNetwork>().noArmor = true;
    }

    public void ActivateItem()
    {

    }


}
