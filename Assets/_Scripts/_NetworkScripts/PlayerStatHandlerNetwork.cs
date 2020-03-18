using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerStatHandlerNetwork : NetworkBehaviour
{
    public GameObject player;
    public GameObject player2;
    public GameObject civilian;
    public GameObject[] civilians;

    public GameObject deathMenuCam;
    public GameObject deathMenuCanvas;

    public Transform pD;

    public static int PlayerHealth = 100;

    public static int PlayerMagic = 100;

    public static int PlayerArrows = 100;

    public static int HPotionCount = 5;

    public static int MPotionCount = 5;

    public static int GoldCount = 0;

    public int GoldCounter = 0;

    public static int ExperienceCount = 0;

    public static int MonstersKilled = 0;

    public static int BossMonstersKilled = 0;

    public static int PeopleKilled = 0;

    public static int woodWeaponDamage = 10;

    public static int ironWeaponDamage = 20;

    public static int steelWeaponDamage = 30;

    public static int shieldDefenseRating = 0;

    public static int armorDefenseRating = 0;

    public static int defenseRating = 0;

    public int DefenseRating = 0;

    public static int woodShieldDefense = 1;

    public static int ironShieldDefense = 2;

    public static int steelShieldDefense = 3;

    public static int leatherArmorDefense = 2;

    public static int ironArmorDefense = 2;

    public static int steelArmorDefense = 3;

    public static int monsterDamage = 5;

    public int MonsterDamage = 0;

    public static int totalMonsterDamage = 0;

    public GameObject healthTextBox;
    public Text healthText;

    public GameObject magicTextBox;
    public Text magicText;

    public GameObject arrowTextBox;
    public Text arrowText;

    public GameObject invArrowTextBox;
    public Text invArrowText;

    public GameObject hPotionTextBox;
    public Text hPotionText;

    public GameObject invHPotionTextBox;
    public Text invHPotionText;

    public GameObject mPotionTextBox;
    public Text mPotionText;

    public GameObject invMPotionTextBox;
    public Text invMPotionText;

    public GameObject goldTextBox;
    public Text goldText;

    public GameObject invGoldTextBox;
    public Text invGoldText;

    public bool isAlive = false;
    public bool isDead = false;
    public bool hasMagic = false;
    public bool outOfMagic = false;
    public bool hasArrows = false;
    public bool outOfArrows = false;

    public bool hasGold = false;
    public bool hasNoGold = false;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        player = GameObject.FindWithTag("Player");
        player2 = GameObject.FindWithTag("Player2");

        if (player == null)
        {
            gameObject.tag = "Player";
        }
        else if (player != null && player2 == null)
        {
            gameObject.tag = "Player2";
        }

        civilian = GameObject.FindWithTag("Civilian");
        civilians = GameObject.FindGameObjectsWithTag("Civilian");

        deathMenuCam = GameObject.FindWithTag("DeathMenuCamera");
        deathMenuCanvas = GameObject.FindWithTag("DeathMenuCanvas");

        healthTextBox = GameObject.FindWithTag("HealthText");
        magicTextBox = GameObject.FindWithTag("MagicText");
        arrowTextBox = GameObject.FindWithTag("ArrowText");
        invArrowTextBox = GameObject.FindWithTag("InvArrowText");
        hPotionTextBox = GameObject.FindWithTag("HealthPotionText");
        invHPotionTextBox = GameObject.FindWithTag("InvHealthPotionText");
        mPotionTextBox = GameObject.FindWithTag("MagicPotionText");
        invMPotionTextBox = GameObject.FindWithTag("InvMagicPotionText");
        goldTextBox = GameObject.FindWithTag("GoldText");
        invGoldTextBox = GameObject.FindWithTag("InvGoldText");

        isAlive = true;
        hasMagic = true;
        hasArrows = true;
        hasNoGold = true;
        hasGold = false;
    }

    void Update()
    {

        if (!isLocalPlayer)
        {
            return;
        }

        if (HPotionCount > 0 && PlayerHealth < 100 && Input.GetKeyDown(KeyCode.Alpha9))
        {
            HPotionCount = HPotionCount - 1;
            PlayerHealth = PlayerHealth + 20;

            hPotionText = hPotionTextBox.GetComponent<Text>();
            hPotionText.text = "Health Potion: " + HPotionCount;
            invHPotionText = invHPotionTextBox.GetComponent<Text>();
            invHPotionText.text = "Health Potion: " + HPotionCount;
            healthText = healthTextBox.GetComponent<Text>();
            healthText.text = "Health: " + PlayerHealth;
        }
        if (PlayerHealth >= 100)
        {
            PlayerHealth = 100;

            healthText = healthTextBox.GetComponent<Text>();
            healthText.text = "Health: " + PlayerHealth;
        }

        if(PlayerHealth < 0)
        {
            PlayerHealth = 0;

            healthText = healthTextBox.GetComponent<Text>();
            healthText.text = "Health: " + PlayerHealth;
        }

        if (MPotionCount > 0 && PlayerMagic < 100 && Input.GetKeyDown(KeyCode.Alpha0))
        {
            MPotionCount = MPotionCount - 1;
            PlayerMagic = PlayerMagic + 20;

            mPotionText = mPotionTextBox.GetComponent<Text>();
            mPotionText.text = "Magic Potion: " + MPotionCount;
            invMPotionText = invMPotionTextBox.GetComponent<Text>();
            invMPotionText.text = "Magic Potion: " + MPotionCount;
            magicText = magicTextBox.GetComponent<Text>();
            magicText.text = "Magic: " + PlayerMagic;

            hasMagic = true;
            outOfMagic = false;
        }
        if (PlayerMagic >= 100)
        {
            PlayerMagic = 100;

            magicText = magicTextBox.GetComponent<Text>();
            magicText.text = "Magic: " + PlayerMagic;
        }

        if ( GetComponent<WeaponSelectHandlerNetwork>().holdingStaff == true && hasMagic && Input.GetKeyDown(KeyCode.L))
        {
            PlayerMagic = PlayerMagic - 10;

            magicText = magicTextBox.GetComponent<Text>();
            magicText.text = "Magic: " + PlayerMagic;
        }
        if (PlayerMagic <= 0)
        {
            PlayerMagic = 0;

            magicText = magicTextBox.GetComponent<Text>();
            magicText.text = "Magic: " + PlayerMagic;
            outOfMagic = true;
            hasMagic = false;
        }
        else
        {
            hasMagic = true;
            outOfMagic = false;
        }

        if (PlayerArrows >= 100)
        {
            PlayerArrows = 100;

            arrowText = arrowTextBox.GetComponent<Text>();
            arrowText.text = "Arrows: " + PlayerArrows;

            invArrowText = invArrowTextBox.GetComponent<Text>();
            invArrowText.text = "Arrows: " + PlayerArrows;
        }

        if ( GetComponent<WeaponSelectHandlerNetwork>().holdingBow == true && hasArrows && Input.GetKeyDown(KeyCode.L))
        {
            PlayerArrows = PlayerArrows - 1;

            arrowText = arrowTextBox.GetComponent<Text>();
            arrowText.text = "Arrows: " + PlayerArrows;

            invArrowText = invArrowTextBox.GetComponent<Text>();
            invArrowText.text = "Arrows: " + PlayerArrows;
        }
        if (PlayerArrows <= 0)
        {
            PlayerArrows = 0;

            arrowText = arrowTextBox.GetComponent<Text>();
            arrowText.text = "Arrows: " + PlayerArrows;

            invArrowText = invArrowTextBox.GetComponent<Text>();
            invArrowText.text = "Arrows: " + PlayerArrows;
            outOfArrows = true;
            hasArrows = false;
        }
        else
        {
            hasArrows = true;
            outOfArrows = false;
        }

        if (GoldCount > 0)
        {
            hasGold = true;
            hasNoGold = false;
        }

        if (GoldCount <= 0)
        {
            GoldCount = 0;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            GoldCount = 1000;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;
        }

        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            GoldCount = 0;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;
        }

        GoldCounter = GoldCount;

        MonsterDamage = totalMonsterDamage;

        if (totalMonsterDamage < 0)
        {
            totalMonsterDamage = 0;
        }

        defenseRating = shieldDefenseRating + armorDefenseRating;

        DefenseRating = defenseRating;

        if ( GetComponent<WeaponSelectHandlerNetwork>().holdingShield == true &&  GetComponent<WeaponSelectHandlerNetwork>().equippedWoodWeapons == true)
        {
            shieldDefenseRating = woodShieldDefense;
        }

        else if ( GetComponent<WeaponSelectHandlerNetwork>().holdingShield == true &&  GetComponent<WeaponSelectHandlerNetwork>().equippedIronWeapons == true)
        {
            shieldDefenseRating = ironShieldDefense;
        }

        else if ( GetComponent<WeaponSelectHandlerNetwork>().holdingShield == true &&  GetComponent<WeaponSelectHandlerNetwork>().equippedSteelWeapons == true)
        {
            shieldDefenseRating = steelShieldDefense;
        }
        else
        {
            shieldDefenseRating = 0;
        }

        if ( GetComponent<WeaponSelectHandlerNetwork>().equippedLeatherArmor == true)
        {
            armorDefenseRating = leatherArmorDefense;
        }

        else if ( GetComponent<WeaponSelectHandlerNetwork>().equippedIronArmor == true)
        {
            armorDefenseRating = ironArmorDefense;
        }

        else if ( GetComponent<WeaponSelectHandlerNetwork>().equippedSteelArmor == true)
        {
            armorDefenseRating = steelArmorDefense;
        }
        else
        {
            armorDefenseRating = 0;
        }

        totalMonsterDamage = monsterDamage - defenseRating;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Monster")
        {
            PlayerHealth = PlayerHealth - totalMonsterDamage;

            healthText = healthTextBox.GetComponent<Text>();
            healthText.text = "Health: " + PlayerHealth;

            if (PlayerHealth <= 0)
            {               
                player.transform.position = pD.transform.position;

                PlayerHealth = 100;
                /*deathMenuCam.GetComponent<Camera>().enabled = true;
                deathMenuCam.GetComponent<AudioListener>().enabled = true;
                deathMenuCanvas.GetComponent<Canvas>().enabled = true;
                gameObject.SetActive(false);
                this.GetComponent<BoxCollider>().enabled = false;*/
            }
        }
    }

    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.tag == "HPotion")
        {
            HPotionCount = HPotionCount + 1;

            hPotionText = hPotionTextBox.GetComponent<Text>();
            hPotionText.text = "Health Potion: " + HPotionCount;

            invHPotionText = invHPotionTextBox.GetComponent<Text>();
            invHPotionText.text = "Health Potion: " + HPotionCount;
        }

        if (Player.gameObject.tag == "MPotion")
        {
            MPotionCount = MPotionCount + 1;

            mPotionText = mPotionTextBox.GetComponent<Text>();
            mPotionText.text = "Magic Potion: " + MPotionCount;

            invMPotionText = invMPotionTextBox.GetComponent<Text>();
            invMPotionText.text = "Magic Potion: " + MPotionCount;
        }

        if (Player.gameObject.tag == "WArrowPickup")
        {
            PlayerArrows = PlayerArrows + 5;

            arrowText = arrowTextBox.GetComponent<Text>();
            arrowText.text = "Arrows: " + PlayerArrows;

            invArrowText = invArrowTextBox.GetComponent<Text>();
            invArrowText.text = "Arrows: " + PlayerArrows;
        }

        if (Player.gameObject.tag == "Gold")
        {
            GoldCount = GoldCount + 1;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;
        }
    }

    void OnTriggerStay(Collider Player)
    {

        if (Player.gameObject.tag == "WoodWeaponTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveWoodWeapons == false && GoldCount >= 10 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 10;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveWoodWeapons = true;
        }

        if (Player.gameObject.tag == "IronWeaponTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveIronWeapons == false && GoldCount >= 25 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 25;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveIronWeapons = true;
        }

        if (Player.gameObject.tag == "SteelWeaponTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveSteelWeapons == false && GoldCount >= 50 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 50;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveSteelWeapons = true;
        }
        if (Player.gameObject.tag == "LeatherArmorTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveLeatherArmor == false && GoldCount >= 10 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 10;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveLeatherArmor = true;
        }

        if (Player.gameObject.tag == "IronArmorTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveIronArmor == false && GoldCount >= 25 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 25;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveIronArmor = true;
        }

        if (Player.gameObject.tag == "SteelArmorTable" &&  GetComponent<WeaponSelectHandlerNetwork>().haveSteelArmor == false && GoldCount >= 50 && Input.GetKeyDown(KeyCode.E))
        {
            GoldCount = GoldCount - 50;

            goldText = goldTextBox.GetComponent<Text>();
            goldText.text = "Gold: " + GoldCount;

            invGoldText = invGoldTextBox.GetComponent<Text>();
            invGoldText.text = "Gold: " + GoldCount;

             GetComponent<WeaponSelectHandlerNetwork>().haveSteelArmor = true;
        }

        if (Player.gameObject.tag == "HPotionMerchantTable" && GoldCount >= 10)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GoldCount = GoldCount - 10;

                goldText = goldTextBox.GetComponent<Text>();
                goldText.text = "Gold: " + GoldCount;

                invGoldText = invGoldTextBox.GetComponent<Text>();
                invGoldText.text = "Gold: " + GoldCount;

                HPotionCount = HPotionCount + 1;

                hPotionText = hPotionTextBox.GetComponent<Text>();
                hPotionText.text = "Health Potion: " + HPotionCount;

                invHPotionText = invHPotionTextBox.GetComponent<Text>();
                invHPotionText.text = "Health Potion: " + HPotionCount;
            }
        }

        if (Player.gameObject.tag == "MPotionMerchantTable" && GoldCount >= 10)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GoldCount = GoldCount - 10;

                goldText = goldTextBox.GetComponent<Text>();
                goldText.text = "Gold: " + GoldCount;

                invGoldText = invGoldTextBox.GetComponent<Text>();
                invGoldText.text = "Gold: " + GoldCount;

                MPotionCount = MPotionCount + 1;

                mPotionText = mPotionTextBox.GetComponent<Text>();
                mPotionText.text = "Magic Potion: " + MPotionCount;

                invMPotionText = invMPotionTextBox.GetComponent<Text>();
                invMPotionText.text = "Magic Potion: " + MPotionCount;
            }
        }

        if (Player.gameObject.tag == "ArrowMerchantTable" && GoldCount >= 20)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GoldCount = GoldCount - 20;

                goldText = goldTextBox.GetComponent<Text>();
                goldText.text = "Gold: " + GoldCount;

                invGoldText = invGoldTextBox.GetComponent<Text>();
                invGoldText.text = "Gold: " + GoldCount;

                PlayerArrows = PlayerArrows + 10;

                arrowText = arrowTextBox.GetComponent<Text>();
                arrowText.text = "Arrows: " + PlayerArrows;

                invArrowText = invArrowTextBox.GetComponent<Text>();
                invArrowText.text = "Arrows: " + PlayerArrows;
            }
        }
    }
}
