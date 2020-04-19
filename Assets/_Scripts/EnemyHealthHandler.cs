using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class EnemyHealthHandler : MonoBehaviour
{
    public PlayerStatHandler playerStatHandler;

    public Animator enemyAnims;

    public int enemyHealth;

    public GameObject healthBar;

    public RectTransform healthBarForeground;
    public RectTransform healthBarBackground;

    public GameObject monstersKilledTextBox;
    public Text monstersKilledText;
    public GameObject experienceTextBox;
    public Text experienceText;
    public GameObject invExperienceTextBox;
    public Text invExperienceText;
    public bool isDead = false;


    void Start()
    {
        monstersKilledTextBox = GameObject.FindWithTag("MonstersKilledText");

        experienceTextBox = GameObject.FindWithTag("ExperienceText");
        invExperienceTextBox = GameObject.FindWithTag("InvExperienceText");

        enemyHealth = Random.Range(50, 100);

        //healthBarBackground.sizeDelta = new Vector2(enemyHealth, healthBarBackground.sizeDelta.y);
    }

    void Update()
    {        

        if (enemyHealth < 0)
        {
            enemyHealth = 0;

            this.GetComponent<ObjectTreasureSpawnScript>().enabled = true;
            Destroy(gameObject, 0.1f);

            PlayerStatHandler.MonstersKilled += 1;

            monstersKilledText = monstersKilledTextBox.GetComponent<Text>();
            monstersKilledText.text = "Monsters Killed: " + PlayerStatHandler.MonstersKilled;

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
            Debug.Log(PlayerStatHandler.woodWeaponDamage);
            enemyHealth = enemyHealth - PlayerStatHandler.woodWeaponDamage;
            healthBarForeground.sizeDelta = new Vector2(enemyHealth, healthBarForeground.sizeDelta.y);
        }

        if (collidedWith.tag == "ISword" || collidedWith.tag == "IDagger" || collidedWith.tag == "IClub" || collidedWith.tag == "IStaff" || collidedWith.tag == "IArrow")
            {
                enemyHealth = enemyHealth - PlayerStatHandler.ironWeaponDamage;
            healthBarForeground.sizeDelta = new Vector2(enemyHealth, healthBarForeground.sizeDelta.y);
        }

        if (collidedWith.tag == "SSword" || collidedWith.tag == "SDagger" || collidedWith.tag == "SClub" || collidedWith.tag == "SStaff" || collidedWith.tag == "SArrow")
            {
                enemyHealth = enemyHealth - PlayerStatHandler.steelWeaponDamage;
            healthBarForeground.sizeDelta = new Vector2(enemyHealth, healthBarForeground.sizeDelta.y);
        }

        
    }

    /*void OnCollisionExit(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "WSword" || collidedWith.tag == "WDagger" || collidedWith.tag == "WClub" || collidedWith.tag == "WStaff" || collidedWith.tag == "WArrow" || collidedWith.tag == "MagicBall" || collidedWith.tag == "Fist")
        {
            enemyAnims.SetBool("isHurt", false);
        }

        if (collidedWith.tag == "ISword" || collidedWith.tag == "IDagger" || collidedWith.tag == "IClub" || collidedWith.tag == "IStaff" || collidedWith.tag == "IArrow")
        {
            enemyAnims.SetBool("isHurt", false);
        }

        if (collidedWith.tag == "SSword" || collidedWith.tag == "SDagger" || collidedWith.tag == "SClub" || collidedWith.tag == "SStaff" || collidedWith.tag == "SArrow")
        {
            enemyAnims.SetBool("isHurt", false);
        }
    }*/
    void OnTriggerEnter(Collider Player)
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
