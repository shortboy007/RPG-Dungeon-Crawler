using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthHandler : MonoBehaviour
{
    public PlayerStatHandler playerStatHandler;

    public Animator enemyAnims;

    public int enemyHealth;

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
    }

    void Update()
    {
        
        if(enemyHealth < 0)
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
            enemyHealth = enemyHealth - PlayerStatHandler.woodWeaponDamage;
        }

        if (collidedWith.tag == "ISword" || collidedWith.tag == "IDagger" || collidedWith.tag == "IClub" || collidedWith.tag == "IStaff" || collidedWith.tag == "IArrow")
            {
                enemyHealth = enemyHealth - PlayerStatHandler.ironWeaponDamage;
            }

        if (collidedWith.tag == "SSword" || collidedWith.tag == "SDagger" || collidedWith.tag == "SClub" || collidedWith.tag == "SStaff" || collidedWith.tag == "SArrow")
            {
                enemyHealth = enemyHealth - PlayerStatHandler.steelWeaponDamage;
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

}
