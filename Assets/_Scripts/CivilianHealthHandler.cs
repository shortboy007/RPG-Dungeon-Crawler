using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CivilianHealthHandler : MonoBehaviour
{
    public PlayerStatHandler playerStatHandler;

    public GameObject player;

    public int civilianHealth;

    public GameObject healthBar;

    public RectTransform healthBarForeground;
    public RectTransform healthBarBackground;

    public GameObject peopleKilledTextBox;
    public Text peopleKilledText;
    public GameObject experienceTextBox;
    public Text experienceText;
    public GameObject invExperienceTextBox;
    public Text invExperienceText;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        peopleKilledTextBox = GameObject.FindWithTag("PeopleKilledText");
        experienceTextBox = GameObject.FindWithTag("ExperienceText");
        invExperienceTextBox = GameObject.FindWithTag("InvExperienceText");

        civilianHealth = Random.Range(25, 50);

        //healthBarBackground.sizeDelta = new Vector2(civilianHealth, healthBarBackground.sizeDelta.y);
    }

    void Update()
    {

        if (civilianHealth < 0)
        {
            civilianHealth = 0;

            this.GetComponent<ObjectTreasureSpawnScript>().enabled = true;
            Destroy(gameObject, 0.1f);

            PlayerStatHandler.PeopleKilled += 1;

            peopleKilledText = peopleKilledTextBox.GetComponent<Text>();
            peopleKilledText.text = "People Killed: " + PlayerStatHandler.PeopleKilled;

            PlayerStatHandler.ExperienceCount += 25;

            experienceText = experienceTextBox.GetComponent<Text>();
            experienceText.text = "Experience: " + PlayerStatHandler.ExperienceCount;

            invExperienceText = invExperienceTextBox.GetComponent<Text>();
            invExperienceText.text = "Experience: " + PlayerStatHandler.ExperienceCount;
            this.GetComponent<BoxCollider>().enabled = false;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "WSword" || collidedWith.tag == "WDagger" || collidedWith.tag == "WClub" || collidedWith.tag == "WStaff" || collidedWith.tag == "WArrow" || collidedWith.tag == "MagicBall" || collidedWith.tag == "Fist")
        {
            civilianHealth = civilianHealth - PlayerStatHandler.woodWeaponDamage;            
            healthBarForeground.sizeDelta = new Vector2(civilianHealth, healthBarForeground.sizeDelta.y);
        }

        if (collidedWith.tag == "ISword" || collidedWith.tag == "IDagger" || collidedWith.tag == "IClub" || collidedWith.tag == "IStaff" || collidedWith.tag == "IArrow")
        {
            civilianHealth = civilianHealth - PlayerStatHandler.ironWeaponDamage;
            healthBarForeground.sizeDelta = new Vector2(civilianHealth, healthBarForeground.sizeDelta.y);
        }

        if (collidedWith.tag == "SSword" || collidedWith.tag == "SDagger" || collidedWith.tag == "SClub" || collidedWith.tag == "SStaff" || collidedWith.tag == "SArrow")
        {
            civilianHealth = civilianHealth - PlayerStatHandler.steelWeaponDamage;
            healthBarForeground.sizeDelta = new Vector2(civilianHealth, healthBarForeground.sizeDelta.y);
        }
    }

    void OnTriggerStay(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            healthBar.SetActive(true);
        }
    }
    void OnTriggerExit(Collider Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            healthBar.SetActive(false);
        }
    }
}
