using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLocationHandlerSeparateWeaponTypes : MonoBehaviour
{
    public GameObject player;
    public Transform playerWeaponHand;
    public Transform playerShieldHand;
    public Transform arrowSpawn;
    public Transform magicSpawn;

    public Transform swordSpawn;
    public Transform daggerSpawn;
    public Transform clubSpawn;
    public Transform staffSpawn;
    public Transform bowSpawn;
    public Transform shieldSpawn;

    public GameObject wSword;
    public GameObject wDagger;
    public GameObject wClub;
    public GameObject wStaff;
    public GameObject magicBall;
    public GameObject wBow;
    public GameObject wArrow;
    public GameObject wShield;

    public GameObject barrier;

    public GameObject textBox;
    public Text text;

    public bool notHoldingWeapon = false;
    public bool notHoldingShield = false;
    public bool holdingSword = false;
    public bool holdingDagger = false;
    public bool holdingClub = false;
    public bool holdingStaff = false;
    public bool holdingBow = false;
    public bool holdingShield = false;
    public bool holdingWeapon = false;

    public bool closeToWSword = false;
    public bool closeToWDagger = false;
    public bool closeToWClub = false;
    public bool closeToWStaff = false;
    public bool closeToWBow = false;
    public bool closeToWShield = false;

    public bool closeToBarrier = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerWeaponHand = GameObject.FindWithTag("PlayerWeaponHand").transform;
        playerShieldHand = GameObject.FindWithTag("PlayerShieldHand").transform;

        arrowSpawn = GameObject.FindWithTag("ArrowSpawn").transform;
        magicSpawn = GameObject.FindWithTag("MagicSpawn").transform;

        /*wSword = GameObject.FindWithTag("WSword");
        wDagger = GameObject.FindWithTag("WDagger");
        wClub = GameObject.FindWithTag("WClub");
        wStaff = GameObject.FindWithTag("WStaff");
        wBow = GameObject.FindWithTag("WBow");
        //wArrow = GameObject.FindWithTag("WArrow");
        wShield = GameObject.FindWithTag("WShield");
        barrier = GameObject.FindWithTag("Barrier");*/

        textBox = GameObject.FindWithTag("LocationText");

    //notHoldingWeapon = true;
    //notHoldingShield = true;
    }

    // Update is called once per frame
    void Update()
    {
        float distToWSword = Vector3.Distance(player.transform.position, wSword.transform.position);
        //Debug.Log("Wood Sword" + distToWSword);
        if (distToWSword <= 4)
        {
            closeToWSword = true;
        }
        else
        {
            closeToWSword = false;
        }
        float distToWDagger = Vector3.Distance(player.transform.position, wDagger.transform.position);
        
        if (distToWDagger <= 4)
        {
            closeToWDagger = true;
        }
        else
        {
            closeToWDagger = false;
        }
        float distToWClub = Vector3.Distance(player.transform.position, wClub.transform.position);

        if (distToWClub <= 4)
        {
            closeToWClub = true;
        }
        else
        {
            closeToWClub = false;
        }
        float distToWStaff = Vector3.Distance(player.transform.position, wStaff.transform.position);

        if (distToWStaff <= 4)
        {
            closeToWStaff = true;
        }
        else
        {
            closeToWStaff = false;
        }
        float distToWBow = Vector3.Distance(player.transform.position, wBow.transform.position);

        if (distToWBow <= 4)
        {
            closeToWBow = true;
        }
        else
        {
            closeToWBow = false;
        }
        float distToWShield = Vector3.Distance(player.transform.position, wShield.transform.position);
        //Debug.Log("Wood Shield" + distToWShield);
        if (distToWShield <= 4)
        {
            closeToWShield = true;
        }
        else
        {
            closeToWShield = false;
        }

        float distToBarrier = Vector3.Distance(player.transform.position, barrier.transform.position);
        //Debug.Log("Barrier" + distToWShield);
        if (distToBarrier < 4)
        {
            closeToBarrier = true;
        }
        else
        {
            closeToBarrier = false;
        }


        if (closeToWSword && notHoldingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Sword.";
        }
        else if (closeToWDagger && notHoldingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Dagger.";
        }
        else if (closeToWClub && notHoldingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Club.";
        }
        else if (closeToWStaff && notHoldingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Staff.";
        }
        else if (closeToWBow && notHoldingWeapon && notHoldingShield)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Bow.";
        }
        else if (closeToWShield && notHoldingShield)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press Q to grab a Wood Shield.";
        }
        else if (closeToWSword && holdingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Sword. Press R to drop current weapon.";
        }
        else if (closeToWDagger && holdingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Dagger. Press R to drop current weapon.";
        }
        else if (closeToWClub && holdingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Club. Press R to drop current weapon.";
        }
        else if (closeToWStaff && holdingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Staff. Press R to drop current weapon.";
        }
        else if (closeToWBow && holdingWeapon)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press E to grab a Wood Bow. Press R to drop current weapon.";
        }
        else if (closeToWBow && holdingShield)
        {
            text = textBox.GetComponent<Text>();
            text.text = "You cannot hold a shield while using a bow. Press T to drop current shield.";
        }
        else if (closeToWShield && holdingShield)
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press Q to grab a Wood Shield. Press T to drop current shield.";
        }
        if (closeToBarrier)
        {
            text = textBox.GetComponent<Text>();
            text.text = "You are trapped in this dungeon! Find and kill the boss monster to earn your freedom.";
        }
        else
        {
            text = textBox.GetComponent<Text>();
            text.text = "Press WASD to move and Left Shift to run.";
        }
        if (closeToWSword && notHoldingWeapon && Input.GetKeyDown(KeyCode.E))
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
        else if (closeToWDagger && notHoldingWeapon && Input.GetKeyDown(KeyCode.E))
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
        else if (closeToWClub && notHoldingWeapon && Input.GetKeyDown(KeyCode.E))
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
        else if (closeToWStaff && notHoldingWeapon && Input.GetKeyDown(KeyCode.E))
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
        else if (closeToWBow && notHoldingWeapon && notHoldingShield && Input.GetKeyDown(KeyCode.E))
        {
            wBow.GetComponent<BowPickup>().enabled = true;
            holdingBow = true;
            notHoldingWeapon = false;
        }
        else if (holdingBow && Input.GetKeyDown(KeyCode.R))
        {
            wBow.GetComponent<BowPickup>().enabled = false;
            wBow.transform.position = bowSpawn.transform.position;
            holdingBow = false;
            notHoldingWeapon = true;
        }
        else if (closeToWShield && notHoldingShield && Input.GetKeyDown(KeyCode.Q))
        {
            wShield.GetComponent<ShieldPickup>().enabled = true;
            holdingShield = true;
            notHoldingShield = false;
        }
        else if (holdingShield && Input.GetKeyDown(KeyCode.T))
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

        if (holdingStaff && Input.GetKeyDown(KeyCode.J))
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

        Destroy(magicProjectile, 5.0f);
    }


}