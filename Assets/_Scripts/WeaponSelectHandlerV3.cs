using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectHandlerV3 : MonoBehaviour
{
    public GameObject player;
    //public Transform playerWeaponHand;
    //public Transform playerShieldHand;

    public GameObject wSword;
    public GameObject wDagger;
    public GameObject wClub;
    public GameObject wStaff;
    public GameObject wBow;  
    public GameObject wShield;

    public GameObject iSword;
    public GameObject iDagger;
    public GameObject iClub;
    public GameObject iStaff;
    public GameObject iBow;
    public GameObject iShield;

    public GameObject sSword;
    public GameObject sDagger;
    public GameObject sClub;
    public GameObject sStaff;
    public GameObject sBow;
    public GameObject sShield;

    public GameObject lantern;

    public GameObject thisBody;

    public GameObject magicBall;
    public GameObject wArrow;
    public GameObject iArrow;
    public GameObject sArrow;

    public Transform arrowSpawn;
    public Transform magicSpawn;

    public Material skin;
    public Material clothes;
    public Material shoes;

    public Material leatherArmor;
    public Material ironArmor;
    public Material steelArmor;

    public GameObject woodWeaponsEquipTextBox;
    public Text woodWeaponsEquipText;

    public static GameObject ironWeaponsEquipTextBox;
    public static Text ironWeaponsEquipText;

    public GameObject steelWeaponsEquipTextBox;
    public Text steelWeaponsEquipText;

    public static GameObject leatherArmorEquipTextBox;
    public static Text leatherArmorEquipText;

    public GameObject ironArmorEquipTextBox;
    public Text ironArmorEquipText;

    public static GameObject steelArmorEquipTextBox;
    public static Text steelArmorEquipText;

    public bool notHoldingWeapon = false;
    public bool notHoldingShield = false;
    public bool notHoldingBow = false;
    public bool holdingSword = false;
    public bool holdingDagger = false;
    public bool holdingClub = false;
    public bool holdingStaff = false;
    public bool holdingBow = false;
    public bool holdingShield = false;
    public bool holdingLantern = false;
    public bool holdingKey = false;

    public bool noWeapon = false;
    public bool haveWoodWeapons = false;
    public bool haveIronWeapons = false;
    public bool haveSteelWeapons = false;

    public bool equippedWoodWeapons = false;
    public bool equippedIronWeapons = false;
    public bool equippedSteelWeapons = false;

    public bool noArmor = false;
    public bool haveLeatherArmor = false;
    public bool haveIronArmor = false;
    public bool haveSteelArmor = false;

    public bool equippedLeatherArmor = false;
    public bool equippedIronArmor = false;
    public bool equippedSteelArmor = false;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");       

        woodWeaponsEquipTextBox = GameObject.FindWithTag("WoodWeaponsSetEquipText");
        ironWeaponsEquipTextBox = GameObject.FindWithTag("IronWeaponsSetEquipText");
        steelWeaponsEquipTextBox = GameObject.FindWithTag("SteelWeaponsSetEquipText");
        leatherArmorEquipTextBox = GameObject.FindWithTag("LeatherArmorSetEquipText");
        ironArmorEquipTextBox = GameObject.FindWithTag("IronArmorSetEquipText");
        steelArmorEquipTextBox = GameObject.FindWithTag("SteelArmorSetEquipText");

        notHoldingWeapon = true;
        notHoldingShield = true;
        notHoldingBow = true;
        holdingLantern = false;
        haveWoodWeapons = true;
        equippedWoodWeapons = true;
        noArmor = true;
    }

    // Update is called once per frame
    void Update()
    {
        thisBody = GameObject.FindWithTag("ThisBody");

        if (Input.GetKeyDown(KeyCode.Alpha1) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wSword
            unequipWeapons();
            wSword.SetActive(true);
            holdingSword = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wDagger
            unequipWeapons();
            wDagger.SetActive(true);
            holdingDagger = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wClub
            unequipWeapons();
            wClub.SetActive(true);
            holdingClub = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wStaff
            unequipWeapons();
            wStaff.SetActive(true);
            holdingStaff = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wBow
            unequipWeapons();
            unequipShield();
            unequipLantern();
            wBow.SetActive(true);
            holdingBow = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && haveWoodWeapons && equippedWoodWeapons)
        {
            //wshield
            unequipBow();
            unequipLantern();
            wShield.SetActive(true);
            holdingShield = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && haveIronWeapons && equippedIronWeapons)
        {
            //iSword
            unequipWeapons();
            iSword.SetActive(true);
            holdingSword = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && haveIronWeapons && equippedIronWeapons)
        {
            //iDagger
            unequipWeapons();
            iDagger.SetActive(true);
            holdingDagger = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && haveIronWeapons && equippedIronWeapons)
        {
            //iClub
            unequipWeapons();
            iClub.SetActive(true);
            holdingClub = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && haveIronWeapons && equippedIronWeapons)
        {
            //iStaff
            unequipWeapons();
            iStaff.SetActive(true);
            holdingStaff = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && haveIronWeapons && equippedIronWeapons)
        {
            //iBow
            unequipWeapons();
            unequipShield();
            unequipLantern();
            iBow.SetActive(true);
            holdingBow = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && haveIronWeapons && equippedIronWeapons)
        {
            //ishield
            unequipBow();
            unequipLantern();
            iShield.SetActive(true);
            holdingShield = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sSword
            unequipWeapons();
            sSword.SetActive(true);
            holdingSword = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sDagger
            unequipWeapons();
            sDagger.SetActive(true);
            holdingDagger = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sClub
            unequipWeapons();
            sClub.SetActive(true);
            holdingClub = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sStaff
            unequipWeapons();
            sStaff.SetActive(true);
            holdingStaff = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sBow
            unequipWeapons();
            unequipShield();
            unequipLantern();
            sBow.SetActive(true);
            holdingBow = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) && haveSteelWeapons && equippedSteelWeapons)
        {
            //sShield
            unequipBow();
            unequipLantern();
            sShield.SetActive(true);
            holdingShield = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            unequipBow();
            unequipShield();
            lantern.SetActive(true);
            holdingLantern = true;
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            unequipWeapons();
            unequipShield();
            unequipLantern();
            notHoldingWeapon = true;
        }

        if (player.GetComponent<PlayerStatHandler>().hasArrows == true && holdingBow && Input.GetKeyDown(KeyCode.L) || player.GetComponent<PlayerStatHandler>().hasArrows == true && holdingBow && Input.GetMouseButtonDown(2))
        {
            shootArrow();
        }

        if (player.GetComponent<PlayerStatHandler>().hasMagic == true && holdingStaff && Input.GetKeyDown(KeyCode.L) || player.GetComponent<PlayerStatHandler>().hasMagic == true && holdingStaff && Input.GetMouseButtonDown(2))
        {
            castMagic();
        }

        if(noWeapon)
        {
            weaponEquipModeReset();
            unequipWeapons();
        }

        if(haveWoodWeapons && equippedWoodWeapons)
        {
            weaponEquipModeReset();
            woodWeaponsEquipText = woodWeaponsEquipTextBox.GetComponent<Text>();
            woodWeaponsEquipText.text = "Equipped";
            noWeapon = false;
        }

        if (haveIronWeapons && equippedIronWeapons)
        {
            weaponEquipModeReset();
            ironWeaponsEquipText = ironWeaponsEquipTextBox.GetComponent<Text>();
            ironWeaponsEquipText.text = "Equipped";
            noWeapon = false;
        }

        if (haveSteelWeapons && equippedSteelWeapons)
        {
            weaponEquipModeReset();
            steelWeaponsEquipText = steelWeaponsEquipTextBox.GetComponent<Text>();
            steelWeaponsEquipText.text = "Equipped";
            noWeapon = false;
        }

        if(noArmor)
        {
            armorEquipModeReset();
            unequipArmor();
        }

        if(haveLeatherArmor && equippedLeatherArmor)
        {
            armorEquipModeReset();
            equipLeatherArmor();
            leatherArmorEquipText = leatherArmorEquipTextBox.GetComponent<Text>();
            leatherArmorEquipText.text = "Equipped";
            noArmor = false;
        }

        if (haveIronArmor && equippedIronArmor)
        {
            armorEquipModeReset();
            equipIronArmor();
            ironArmorEquipText = ironArmorEquipTextBox.GetComponent<Text>();
            ironArmorEquipText.text = "Equipped";
            noArmor = false;
        }

        if (haveSteelArmor && equippedSteelArmor)
        {
            armorEquipModeReset();
            equipSteelArmor();
            steelArmorEquipText = steelArmorEquipTextBox.GetComponent<Text>();
            steelArmorEquipText.text = "Equipped";
            noArmor = false;
        }
    }

    public void unequipWeapons()
    {
        wSword.SetActive(false);
        wDagger.SetActive(false);
        wClub.SetActive(false);
        wStaff.SetActive(false);
        wBow.SetActive(false);
        iSword.SetActive(false);
        iDagger.SetActive(false);
        iClub.SetActive(false);
        iStaff.SetActive(false);
        iBow.SetActive(false);
        sSword.SetActive(false);
        sDagger.SetActive(false);
        sClub.SetActive(false);
        sStaff.SetActive(false);
        sBow.SetActive(false);
        holdingSword = false;
        holdingDagger = false;
        holdingClub = false;
        holdingStaff = false;
        holdingBow = false;
    }
    public void unequipShield()
    {
        wShield.SetActive(false);
        iShield.SetActive(false);
        sShield.SetActive(false);
        holdingShield = false;
    }
     public void unequipBow()
    {
        wBow.SetActive(false);
        iBow.SetActive(false);
        sBow.SetActive(false);
        holdingBow = false;
    }
    public void unequipLantern()
    {
        lantern.SetActive(false);
        holdingLantern = false;
    }

    public void unequipArmor()
    {
        armorEquipModeReset();
        noArmor = true;
        //thisBody.GetComponent<Renderer>().material = clothes;
    }

    public void equipLeatherArmor()
    {
        noArmor = false;
        thisBody.GetComponent<Renderer>().material = leatherArmor;
    }

    public void equipIronArmor()
    {
        noArmor = false;
        thisBody.GetComponent<Renderer>().material = ironArmor;
    }

    public void equipSteelArmor()
    {
        noArmor = false;
        thisBody.GetComponent<Renderer>().material = steelArmor;

    }

    public void weaponEquipModeReset()
    {
        woodWeaponsEquipText = woodWeaponsEquipTextBox.GetComponent<Text>();
        woodWeaponsEquipText.text = "Not Equipped";

        ironWeaponsEquipText = ironWeaponsEquipTextBox.GetComponent<Text>();
        ironWeaponsEquipText.text = "Not Equipped";

        steelWeaponsEquipText = steelWeaponsEquipTextBox.GetComponent<Text>();
        steelWeaponsEquipText.text = "Not Equipped";
    }

    public void armorEquipModeReset()
    {
        leatherArmorEquipText = leatherArmorEquipTextBox.GetComponent<Text>();
        leatherArmorEquipText.text = "Not Equipped";

        ironArmorEquipText = ironArmorEquipTextBox.GetComponent<Text>();
        ironArmorEquipText.text = "Not Equipped";

        steelArmorEquipText = steelArmorEquipTextBox.GetComponent<Text>();
        steelArmorEquipText.text = "Not Equipped";
    }

    public void shootArrow()
    {
        if (haveWoodWeapons && equippedWoodWeapons)
        {
            var arrowProjectile = (GameObject)Instantiate(
                wArrow,
                arrowSpawn.position,
                arrowSpawn.rotation);

            arrowProjectile.GetComponent<Rigidbody>().velocity = arrowProjectile.transform.forward * 100.0f;

            Destroy(arrowProjectile, 10.0f);
        }
        if (haveIronWeapons && equippedIronWeapons)
        {
            var arrowProjectile = (GameObject)Instantiate(
                iArrow,
                arrowSpawn.position,
                arrowSpawn.rotation);

            arrowProjectile.GetComponent<Rigidbody>().velocity = arrowProjectile.transform.forward * 100.0f;

            Destroy(arrowProjectile, 10.0f);
        }
        if (haveSteelWeapons && equippedSteelWeapons)
        {
            var arrowProjectile = (GameObject)Instantiate(
                sArrow,
                arrowSpawn.position,
                arrowSpawn.rotation);

            arrowProjectile.GetComponent<Rigidbody>().velocity = arrowProjectile.transform.forward * 100.0f;

            Destroy(arrowProjectile, 10.0f);
        }
    }

     public void castMagic()
    {
        var magicProjectile = (GameObject)Instantiate(
            magicBall,
            magicSpawn.position,
            magicSpawn.rotation);

        magicProjectile.GetComponent<Rigidbody>().velocity = magicProjectile.transform.forward * 100.0f;

        /*playerMagic = playerMagic - 10;
        playerMagicText = playerMagicTextBox.GetComponent<Text>();
        playerMagicText.text = "Magic: " + playerMagic;
        */
        Destroy(magicProjectile, 5.0f);
    }
}
