using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectHandlerV2Backup : MonoBehaviour
{
    public GameObject player;
    //public Transform playerWeaponHand;
    //public Transform playerShieldHand;

    public GameObject wSword;
    public GameObject wDagger;
    public GameObject wClub;
    public GameObject wStaff;
    public GameObject magicBall;
    public GameObject wBow;
    public GameObject wArrow;
    public GameObject wShield;

    public Transform arrowSpawn;
    public Transform magicSpawn;

    public Transform swordSpawn;
    public Transform daggerSpawn;
    public Transform clubSpawn;
    public Transform staffSpawn;
    public Transform bowSpawn;
    public Transform shieldSpawn;
    /*
    public int playerMagic;

    public GameObject playerMagicTextBox;
    public Text playerMagicText;
    */
    public bool notHoldingWeapon = false;
    public bool notHoldingShield = false;
    public bool notHoldingBow = false;
    public bool holdingSword = false;
    public bool holdingDagger = false;
    public bool holdingClub = false;
    public bool holdingStaff = false;
    public bool holdingBow = false;
    public bool holdingShield = false;



    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        //playerWeaponHand = GameObject.FindWithTag("PlayerWeaponHand").transform;
        //playerShieldHand = GameObject.FindWithTag("PlayerShieldHand").transform;

        /*arrowSpawn = GameObject.FindWithTag("ArrowSpawn").transform;
        magicSpawn = GameObject.FindWithTag("MagicSpawn").transform;

        wSword = GameObject.FindWithTag("WSword");
        wDagger = GameObject.FindWithTag("WDagger");
        wClub = GameObject.FindWithTag("WClub");
        wStaff = GameObject.FindWithTag("WStaff");
        //magicBall = GameObject.FindWithTag("MagicBall");
        wBow = GameObject.FindWithTag("WBow");
        //wArrow = GameObject.FindWithTag("WArrow");
        wShield = GameObject.FindWithTag("WShield");

        swordSpawn = GameObject.FindWithTag("SwordSpawn").transform;
        daggerSpawn = GameObject.FindWithTag("DaggerSpawn").transform;
        clubSpawn = GameObject.FindWithTag("ClubSpawn").transform;
        staffSpawn = GameObject.FindWithTag("StaffSpawn").transform;
        bowSpawn = GameObject.FindWithTag("BowSpawn").transform;
        shieldSpawn = GameObject.FindWithTag("ShieldSpawn").transform;
        */
        /*playerMagicTextBox = GameObject.FindWithTag("MagicText");

        playerMagic = PlayerStatHandler.PlayerMagic;
        playerMagicTextBox = PlayerStatHandler.magicTextBox;
        playerMagicText = PlayerStatHandler.magicText;
        */
        //textBox = GameObject.FindWithTag("LocationText");

        notHoldingWeapon = true;
        notHoldingShield = true;
        notHoldingBow = true;
    }

    // Update is called once per frame
    void Update()
    {
        //wSword
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            wSword.SetActive(true);
            wDagger.SetActive(false);
            wClub.SetActive(false);
            wStaff.SetActive(false);
            wBow.SetActive(false);
            //wShield.SetActive(false);
            holdingSword = true;
            holdingDagger = false;
            holdingClub = false;
            holdingStaff = false;
            holdingBow = false;
            //holdingShield = false;
            notHoldingWeapon = false;
        }
        //wDagger
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            wSword.SetActive(false);
            wDagger.SetActive(true);
            wClub.SetActive(false);
            wStaff.SetActive(false);
            wBow.SetActive(false);
            //wShield.SetActive(false);
            holdingSword = false;
            holdingDagger = true;
            holdingClub = false;
            holdingStaff = false;
            holdingBow = false;
            //holdingShield = false;
            notHoldingWeapon = false;
        }
        //wClub
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            wSword.SetActive(false);
            wDagger.SetActive(false);
            wClub.SetActive(true);
            wStaff.SetActive(false);
            wBow.SetActive(false);
            //wShield.SetActive(false);
            holdingSword = false;
            holdingDagger = false;
            holdingClub = true;
            holdingStaff = false;
            holdingBow = false;
            //holdingShield = false;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            //wStaff
            wSword.SetActive(false);
            wDagger.SetActive(false);
            wClub.SetActive(false);
            wStaff.SetActive(true);
            wBow.SetActive(false);
            //wShield.SetActive(false);
            holdingSword = false;
            holdingDagger = false;
            holdingClub = false;
            holdingStaff = true;
            holdingBow = false;
            //holdingShield = false;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //wBow
            wSword.SetActive(false);
            wDagger.SetActive(false);
            wClub.SetActive(false);
            wStaff.SetActive(false);
            wBow.SetActive(true);
            wShield.SetActive(false);
            holdingSword = false;
            holdingDagger = false;
            holdingClub = false;
            holdingStaff = false;
            holdingBow = true;
            holdingShield = false;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            //wShield
            //wSword.SetActive(false);
            //wDagger.SetActive(false);
            //wClub.SetActive(false);
            //wStaff.SetActive(false);
            wBow.SetActive(false);
            wShield.SetActive(true);
            //holdingSword = false;
            //holdingDagger = false;
            //holdingClub = false;
            //holdingStaff = false;
            holdingBow = false;
            holdingShield = true;
            notHoldingWeapon = false;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            unequipWeapons();
        }

        if (player.GetComponent<PlayerStatHandler>().hasArrows == true && holdingBow && Input.GetKeyDown(KeyCode.L))
        {
            shootArrow();
        }

        if (player.GetComponent<PlayerStatHandler>().hasMagic == true && holdingStaff && Input.GetKeyDown(KeyCode.L))
        {
            castMagic();
        }
    }

    void unequipWeapons()
    {
        wSword.SetActive(false);
        wDagger.SetActive(false);
        wClub.SetActive(false);
        wStaff.SetActive(false);
        wBow.SetActive(false);
        wShield.SetActive(false);
        holdingSword = false;
        holdingDagger = false;
        holdingClub = false;
        holdingStaff = false;
        holdingBow = false;
        holdingShield = false;
        notHoldingWeapon = true;
    }

    void unequipWeaponsHoldingShield()
    {
        wBow.SetActive(false);
        wShield.SetActive(false);
        holdingBow = false;
        holdingShield = false;
        notHoldingWeapon = true;
    }

    void shootArrow()
    {

        var arrowProjectile = (GameObject)Instantiate(
            wArrow,
            arrowSpawn.position,
            arrowSpawn.rotation);

        arrowProjectile.GetComponent<Rigidbody>().velocity = arrowProjectile.transform.forward * 100.0f;

        Destroy(arrowProjectile, 10.0f);
    }

    void castMagic()
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
