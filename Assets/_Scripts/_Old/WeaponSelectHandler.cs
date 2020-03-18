using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSelectHandler : MonoBehaviour
{
    public GameObject player;
    public Transform playerWeaponHand;
    public Transform playerShieldHand;

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
        playerWeaponHand = GameObject.FindWithTag("PlayerWeaponHand").transform;
        playerShieldHand = GameObject.FindWithTag("PlayerShieldHand").transform;

        arrowSpawn = GameObject.FindWithTag("ArrowSpawn").transform;
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




     if (notHoldingWeapon && Input.GetKeyDown(KeyCode.Alpha1))
{
    wSword.GetComponent<SwordPickup>().enabled = true;
    holdingSword = true;
    notHoldingWeapon = false;
}
else if (holdingSword && Input.GetKeyDown(KeyCode.R))
{
    wSword.GetComponent<SwordPickup>().enabled = false;
    wSword.transform.position = swordSpawn.transform.position;
    holdingSword = false;
    notHoldingWeapon = true;
}
else if (notHoldingWeapon && Input.GetKeyDown(KeyCode.Alpha2))
{
    wDagger.GetComponent<DaggerPickup>().enabled = true;
    holdingDagger = true;
    notHoldingWeapon = false;
}
else if (holdingDagger && Input.GetKeyDown(KeyCode.R))
{
    wDagger.GetComponent<DaggerPickup>().enabled = false;
    wDagger.transform.position = daggerSpawn.transform.position;
    holdingDagger = false;
    notHoldingWeapon = true;
}
else if (notHoldingWeapon && Input.GetKeyDown(KeyCode.Alpha3))
{
    wClub.GetComponent<ClubPickup>().enabled = true;
    holdingClub = true;
    notHoldingWeapon = false;
}
else if (holdingClub && Input.GetKeyDown(KeyCode.R))
{
    wClub.GetComponent<ClubPickup>().enabled = false;
    wClub.transform.position = clubSpawn.transform.position;
    holdingClub = false;
    notHoldingWeapon = true;
}
else if (notHoldingWeapon && Input.GetKeyDown(KeyCode.Alpha4))
{
    wStaff.GetComponent<StaffPickup>().enabled = true;
    holdingStaff = true;
    notHoldingWeapon = false;
}
else if (holdingStaff && Input.GetKeyDown(KeyCode.R))
{
    wStaff.GetComponent<StaffPickup>().enabled = false;
    wStaff.transform.position = staffSpawn.transform.position;
    holdingStaff = false;
    notHoldingWeapon = true;
}
else if (notHoldingWeapon && notHoldingShield && Input.GetKeyDown(KeyCode.Alpha5))
{
    wBow.GetComponent<BowPickup>().enabled = true;
    holdingBow = true;
    notHoldingBow = false;
    notHoldingWeapon = false;
}
else if (holdingBow && Input.GetKeyDown(KeyCode.R))
{
    wBow.GetComponent<BowPickup>().enabled = false;
    wBow.transform.position = bowSpawn.transform.position;
    holdingBow = false;
    notHoldingBow = true;
    notHoldingWeapon = true;
}
else if (notHoldingShield && notHoldingBow && Input.GetKeyDown(KeyCode.Alpha9))
{
    wShield.GetComponent<ShieldPickup>().enabled = true;
    holdingShield = true;
    notHoldingShield = false;
}
else if (holdingShield && Input.GetKeyDown(KeyCode.R))
{
    wShield.GetComponent<ShieldPickup>().enabled = false;
    wShield.transform.position = shieldSpawn.transform.position;
    holdingShield = false;
    notHoldingShield = true;
}


if (holdingBow && Input.GetKeyDown(KeyCode.J))
{
    shootArrow();
}

if (player.GetComponent<PlayerStatHandler>().hasMagic == true && holdingStaff && Input.GetKeyDown(KeyCode.J))
{
    castMagic();
}
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
