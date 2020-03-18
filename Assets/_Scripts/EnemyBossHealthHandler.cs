using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBossHealthHandler : MonoBehaviour
{
    public Animator enemyAnims;

    public int bossHealth;

    public GameObject bossMonstersKilledTextBox;
    public Text bossMonstersKilledText;
    public GameObject experienceTextBox;
    public Text experienceText;
    public GameObject invExperienceTextBox;
    public Text invExperienceText;
    public static int ExperienceCount = 0;
    public int hitCount = 0;



    void Start()
    {
        bossMonstersKilledTextBox = GameObject.FindWithTag("BossMonstersKilledText");

        experienceTextBox = GameObject.FindWithTag("ExperienceText");
        invExperienceTextBox = GameObject.FindWithTag("InvExperienceText");

        bossHealth = Random.Range(100, 150);
    }

    void Update()
    {

        if (bossHealth < 0)
        {
            bossHealth = 0;

            gameObject.GetComponent<ObjectTreasureSpawnScript>().enabled = true;

            Destroy(gameObject, 0.1f);

            PlayerStatHandler.BossMonstersKilled += 1;

            bossMonstersKilledText = bossMonstersKilledTextBox.GetComponent<Text>();
            bossMonstersKilledText.text = "Boss Monsters Killed: " + PlayerStatHandler.BossMonstersKilled;

            PlayerStatHandler.ExperienceCount += 100;

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
            bossHealth = bossHealth - PlayerStatHandler.woodWeaponDamage;
        }

        if (collidedWith.tag == "ISword" || collidedWith.tag == "IDagger" || collidedWith.tag == "IClub" || collidedWith.tag == "IStaff" || collidedWith.tag == "IArrow")
        {
            bossHealth = bossHealth - PlayerStatHandler.ironWeaponDamage;
        }

        if (collidedWith.tag == "SSword" || collidedWith.tag == "SDagger" || collidedWith.tag == "SClub" || collidedWith.tag == "SStaff" || collidedWith.tag == "SArrow")
        {
            bossHealth = bossHealth - PlayerStatHandler.steelWeaponDamage;

        }
    }
}
