using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationHandlerScript : MonoBehaviour
{
    public GameObject player;

    public GameObject thisBody;

    public GameObject PDKey;
    public GameObject barrier;
    public GameObject teleporter;

    public GameObject noticeBoardT1Canvas;
    public GameObject noticeBoardT2Canvas;
    public GameObject noticeBoardT3Canvas;
    public GameObject noticeBoardT4Canvas;
    public GameObject noticeBoardT5Canvas;

    public Button MMPD;
    public Button MMFD;
    public Button MMID;
    public Button MMSD;
    public Button MMDD;
    public Button MMDT;
    public Button MMT1;
    public Button MMT2;
    public Button MMT3;
    public Button MMT4;
    public Button MMT5;

    public GameObject notificationTextBox;
    public Text notificationText;

    public GameObject locationTextBox;
    public Text locationText;

    public bool holdingKey = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        noticeBoardT1Canvas = GameObject.FindWithTag("NoticeBoardCanvasT1");
        noticeBoardT2Canvas = GameObject.FindWithTag("NoticeBoardCanvasT2");
        noticeBoardT3Canvas = GameObject.FindWithTag("NoticeBoardCanvasT3");
        noticeBoardT4Canvas = GameObject.FindWithTag("NoticeBoardCanvasT4");
        noticeBoardT5Canvas = GameObject.FindWithTag("NoticeBoardCanvasT5");
    }

    // Update is called once per frame
    void Update()
    {
        notificationTextBox = GameObject.FindWithTag("NotificationText");
        locationTextBox = GameObject.FindWithTag("LocationText");
        thisBody = GameObject.FindWithTag("ThisBody");

        /*if(Input.GetKeyDown(KeyCode.Keypad1))
         {
             MMPD.interactable = true;
             MMFD.interactable = true;
             MMID.interactable = true;
             MMSD.interactable = true;
             MMDD.interactable = true;
             MMDT.interactable = true;
             MMT1.interactable = true;
             MMT2.interactable = true;
             MMT3.interactable = true;
             MMT4.interactable = true;
             MMT5.interactable = true;
         }

         if (Input.GetKeyDown(KeyCode.Keypad2))
         {
             MMPD.interactable = false;
             MMFD.interactable = false;
             MMID.interactable = false;
             MMSD.interactable = false;
             MMDD.interactable = false;
             MMDT.interactable = false;
             MMT1.interactable = false;
             MMT2.interactable = false;
             MMT3.interactable = false;
             MMT4.interactable = false;
             MMT5.interactable = false;
         }*/

    }

    void OnTriggerEnter(Collider Player)
    {
        /*if (Player.gameObject.tag == "Civilian" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            CivilianDialogueChoose();
        }
        if (Player.gameObject.tag == "Civilian" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            CivilianSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "Guard" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            GuardDialogueChoose();
        }
        if (Player.gameObject.tag == "Guard" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            GuardSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "Merchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            MerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "Merchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            MerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "WeaponMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            WeaponMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "WeaponMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            WeaponMerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "ArmorMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            ArmorMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "ArmorMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            ArmorMerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "TavernMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null)
        {
            TavernMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "TavernMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null)
        {
            TavernMerchantSeePlayerWeaponDialogueChoose();
        }
        if (thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && PlayerStatHandler.PeopleKilled > 0 && thisBody != null)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "THERE'S A MANIAC KILLING PEOPLE!!!";
        }*/
    }

        void OnTriggerStay(Collider Player)
        {

        if (Player.gameObject.tag == "HPotion")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You got a health potion!";
        }
        if (Player.gameObject.tag == "MPotion")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You got a magic potion!";
        }
        if (Player.gameObject.tag == "Gold")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You got a gold coin!";
        }
        if (Player.gameObject.tag == "WArrowPickup")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You got a bundle of arrows!";
        }
        if (Player.gameObject.tag == "TreasureChest")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to open the chest.";
        }
        if (Player.gameObject.tag == "Key")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to pick up the key.";
        }
        if (Player.gameObject.tag == "Key" && player.GetComponent<NotificationHandlerScript>().holdingKey == true)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press R to drop the key.";
        }
       
        if (Player.gameObject.tag == "WoodWeaponTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy wooden weapons for 10 gold.";
        }
        if (Player.gameObject.tag == "IronWeaponTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy iron weapons for 25 gold.";
        }
        if (Player.gameObject.tag == "SteelWeaponTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy steel weapons for 50 gold.";
        }
        if (Player.gameObject.tag == "LeatherArmorTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy leather armor for 10 gold.";
        }
        if (Player.gameObject.tag == "IronArmorTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy iron armor for 25 gold.";
        }
        if (Player.gameObject.tag == "SteelArmorTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy steel armor for 50 gold.";
        }

        if (Player.gameObject.tag == "HPotionMerchantTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy a health potion for 10 gold.";
        }
        if (Player.gameObject.tag == "MPotionMerchantTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy a magic potion for 10 gold.";
        }
        if (Player.gameObject.tag == "ArrowMerchantTable")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to buy a bundle of 20 arrows for 10 gold.";
        }
        if (Player.gameObject.tag == "NoticeBoardT1" || Player.gameObject.tag == "NoticeBoardT2" || Player.gameObject.tag == "NoticeBoardT3" || Player.gameObject.tag == "NoticeBoardT4" || Player.gameObject.tag == "NoticeBoardT5")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to check for work.";
        }
        if (Player.gameObject.tag == "NoticeBoardT1" && Input.GetKeyDown(KeyCode.E))
        {
            ShowNoticeBoardT1Canvas();
        }
        if (Player.gameObject.tag == "NoticeBoardT2" && Input.GetKeyDown(KeyCode.E))
        {
            ShowNoticeBoardT2Canvas();
        }
        if (Player.gameObject.tag == "NoticeBoardT3" && Input.GetKeyDown(KeyCode.E))
        {
            ShowNoticeBoardT3Canvas();
        }
        if (Player.gameObject.tag == "NoticeBoardT4" && Input.GetKeyDown(KeyCode.E))
        {
            ShowNoticeBoardT4Canvas();
        }
        if (Player.gameObject.tag == "NoticeBoardT5" && Input.GetKeyDown(KeyCode.E))
        {
            ShowNoticeBoardT5Canvas();
        }
        /*if (Player.gameObject.tag == "Civilian" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            CivilianDialogueChoose();
        }
        if (Player.gameObject.tag == "Civilian" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            CivilianSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "Merchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            MerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "Merchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            MerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "WeaponMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            WeaponMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "WeaponMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            WeaponMerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "ArmorMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            ArmorMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "ArmorMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            ArmorMerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "TavernMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            TavernMerchantDialogueChoose();
        }
        if (Player.gameObject.tag == "TavernMerchant" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            TavernMerchantSeePlayerWeaponDialogueChoose();
        }
        if (Player.gameObject.tag == "Guard" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == true && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            GuardDialogueChoose();
        }
        if (Player.gameObject.tag == "Guard" && thisBody.GetComponent<WeaponSelectHandlerV3>().notHoldingWeapon == false && thisBody != null && Input.GetKeyDown(KeyCode.E))
        {
            GuardSeePlayerWeaponDialogueChoose();
        }*/
        if (Player.gameObject.name == "StoneEngravingColliderTutorial1")
            {
                notificationText = notificationTextBox.GetComponent<Text>();
                notificationText.text = "You are trapped in this dungeon! Find and kill the boss monster to earn your freedom.";           
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial2")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press keys 1-5 to equip your weapons. 1 is a sword. 2 is a dagger. 3 is a club. 4 is a staff. 5 is a bow.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial3")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press 6 to equip a shield. Press 7 to equip a lantern. You can't equip a shield, lantern, or bow at the same time.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial4")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press J and K to do a melee attack. L is a ranged attack when a staff or bow is equipped.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial5")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "If you get hit by a monster or other hostile NPC, your health will decrease.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial6")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press 9 to replenish health by using a potion. Press 0 to replenish magic by using a potion. You have a limited number of potions, but you can pick up more from monsters.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial7")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You have a limited amount of magic and arrows so use them sparingly. You can pick up potions and arrows from monsters.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial8")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You can control the camera by pressing the up and down arrow keys. Press V to change between camera viewpoints.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial9")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press Tab to open the main game menu.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial10")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You can use the inventory menu to equip and unequip weapons. Some equipment must be bought before it can be used.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial11")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You can use the map to fast travel to locations you have been to. Simply approach the entryway and the location will activate on the map.";
        }
        if (Player.gameObject.name == "StoneEngravingColliderTutorial12")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You can check the Controls, Objective, and Stats by clicking the corresponding buttons.";
        }
        if (Player.gameObject.tag == "Barrier")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "You need a key to open this door.";
        }
        if (Player.gameObject.tag == "Barrier" && player.GetComponent<NotificationHandlerScript>().holdingKey == true)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to unlock this door.";
        }
        if (Player.gameObject.tag == "TeleportUp")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to go up one floor.";
        }
        if (Player.gameObject.tag == "TeleportDown")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to go down one floor.";
        }
        if (Player.gameObject.tag == "TeleportEntrance")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to go back to the entrance.";
        }
        if (Player.gameObject.name == "TeleporterToPD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter dungeon";

            MMPD.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToFD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Fort Dungeon";

            MMFD.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToSD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Stone Dungeon";

            MMSD.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToID")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Ice Dungeon";

            MMID.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToDD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Desert Dungeon";

            MMDD.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToDT")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Dark Tower Dungeon";

            MMDT.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToOWPD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Practice Dungeon.";
        }
        if (Player.gameObject.name == "TeleporterToOWFD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Fort Dungeon";
        }
        if (Player.gameObject.name == "TeleporterToOWSD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Stone Dungeon";
        }
        if (Player.gameObject.name == "TeleporterToOWID")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Ice Dungeon";
        }
        if (Player.gameObject.name == "TeleporterToOWDD")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Desert Dungeon";
        }
        if (Player.gameObject.name == "TeleporterToOWDT")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to leave Dark Tower Dungeon";
        }
        if (Player.gameObject.name == "TeleporterToOWT1")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to return to the Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToOWT2")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to return to the Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToOWT3")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to return to the Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToOWT4")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to return to the Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToOWT5")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to return to the Overworld.";
        }
        if (Player.gameObject.name == "TeleporterToT1")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Faros.";

            MMT1.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToT2")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Lestos.";

            MMT2.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToT3")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Garem.";

            MMT3.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToT4")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Balis.";

            MMT4.interactable = true;
        }
        if (Player.gameObject.name == "TeleporterToT5")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press E to enter Hedom.";

            MMT5.interactable = true;
        }

        if (Player.gameObject.name == "PlainsArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Plains";
        }
        if (Player.gameObject.name == "ForestArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Forest";
        }
        if (Player.gameObject.name == "DesertArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Desert";
        }
        if (Player.gameObject.name == "MountainArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Mountains";
        }
        if (Player.gameObject.name == "AshPlainsArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Shadow Lands";
        }
        if (Player.gameObject.name == "IceArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Frozen Lands";
        }
        if (Player.gameObject.name == "PracticeDungeon" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Practice Dungeon";
        }
        if (Player.gameObject.name == "StoneDungeon" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Stone Dungeon";
        }
        if (Player.gameObject.name == "FortDungeon" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Fort Dungeon";
        }
        if (Player.gameObject.name == "IceDungeon" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Ice Dungeon";
        }
        if (Player.gameObject.name == "FarosArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Faros";
        }
        if (Player.gameObject.name == "LestosArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Lestos";
        }
        if (Player.gameObject.name == "GaremArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Garem";
        }
        if (Player.gameObject.name == "BalisArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Balis";
        }
        if (Player.gameObject.name == "HedomArea" && locationText != null && locationTextBox != null)
        {
            locationText = locationTextBox.GetComponent<Text>();
            locationText.text = "Hedom";
        }

        if (Player.gameObject.tag == "Key" && Input.GetKeyDown(KeyCode.E))
        {
            thisBody.GetComponent<WeaponSelectHandlerV3>().unequipShield();
            Player.gameObject.GetComponent<ItemPickup>().enabled = true;
            holdingKey = true;
        }
        if (Player.gameObject.tag == "Key" && Input.GetKeyDown(KeyCode.R))
        {
            Player.gameObject.GetComponent<ItemPickup>().enabled = false;
            holdingKey = false;
        }

        if (Player.gameObject.tag == "Barrier" && holdingKey == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                barrier.SetActive(false);
                teleporter.GetComponent<TeleportScript>().enabled = true;
                teleporter.GetComponent<BoxCollider>().enabled = true;
                Destroy(PDKey);
            }
        }

    }

    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "NotificationCollider")
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Press WASD to move and Left Shift to run.";
        }
    }

   /* void CivilianDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: Hello traveler!";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: Welcome to our town!";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: Visit the market if you get the chance!";
        }
    }
    void CivilianSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: A weapon? You must be an adventurer!";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: What do you plan to do with that weapon?";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Civilian: Put the weapon away! That's dangerous!";
        }
    }

    void MerchantDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: See anything you like?";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: Need some potions? Maybe some arrows?";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: Welcome to the general supplies market building!";
        }
    }
    void MerchantSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: A weapon? We don't sell those here.";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: Watch it! You could damage the merchandise!";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Merchant: I don't buy weapons, but thanks for showing me them.";
        }
    }

    void WeaponMerchantDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: See any weapons you like?";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: Buy something, if you want to.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: This is the weapons market building!";
        }
    }
    void WeaponMerchantSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: A weapon? They look old and broken. You need new ones!";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: Watch where you point that thing.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Weapon Merchant: You already have weapons. Do you want to upgrade?";
        }
    }

    void ArmorMerchantDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: See any armor you like?";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: Buy something, if you want to.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: This is the armor market building!";
        }
    }
    void ArmorMerchantSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: A weapon? No. I deal in defense, not dealing damage.";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: Be careful not to damage the armor. It won't help you in battle if its already broken.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Armor Merchant: You already have weapons. You need new armor. Buy some.";
        }
    }
    void TavernMerchantDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: Welcome to the tavern!";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: Need a drink?";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: You an adventurer? Check the post outside for work.";
        }
    }
    void TavernMerchantSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: A weapon? We serve drinks here sir, not violence.";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: Bar fights are fists and improvised weapons only sir.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Tavern Keeper: Put your weapon away and join the party. Here's a drink on the house.";
        }
    }
    void GuardDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: Hello citizen.";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: Welcome to our town.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: Stay out of trouble.";
        }
    }
    void GuardSeePlayerWeaponDialogueChoose()
    {
        var dialogueOptionToSay = Random.Range(0, 3);

        if (dialogueOptionToSay == 0)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: This is a peaceful town sir. Please sheathe your weapon.";
        }
        else if (dialogueOptionToSay == 1)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: Waving a weapon in town is dangerous. Please put it away while you are in town.";
        }
        else if (dialogueOptionToSay == 2)
        {
            notificationText = notificationTextBox.GetComponent<Text>();
            notificationText.text = "Guard: Put the weapon away unless you want trouble.";
        }
    }*/

    public void ShowNoticeBoardT1Canvas()
    {
            noticeBoardT1Canvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowNoticeBoardT2Canvas()
    {
        noticeBoardT2Canvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowNoticeBoardT3Canvas()
    {
        noticeBoardT3Canvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowNoticeBoardT4Canvas()
    {
        noticeBoardT4Canvas.GetComponent<Canvas>().enabled = true;
    }

    public void ShowNoticeBoardT5Canvas()
    {
        noticeBoardT5Canvas.GetComponent<Canvas>().enabled = true;
    }

    public void HideNoticeBoardCanvas()
    {
        noticeBoardT1Canvas.GetComponent<Canvas>().enabled = false;
        noticeBoardT2Canvas.GetComponent<Canvas>().enabled = false;
        noticeBoardT3Canvas.GetComponent<Canvas>().enabled = false;
        noticeBoardT4Canvas.GetComponent<Canvas>().enabled = false;
        noticeBoardT5Canvas.GetComponent<Canvas>().enabled = false;
    }
}
