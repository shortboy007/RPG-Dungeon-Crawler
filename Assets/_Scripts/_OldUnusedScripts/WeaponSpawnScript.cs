using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSpawnScript : MonoBehaviour
{
    public GameObject player;

    public GameObject woodSword;
    public GameObject woodDagger;
    public GameObject woodClub;
    public GameObject woodStaff;
    public GameObject woodBow;
    public GameObject woodShield;
    public GameObject ironSword;
    public GameObject ironDagger;
    public GameObject ironClub;
    public GameObject ironStaff;
    public GameObject ironBow;
    public GameObject ironShield;
    public GameObject steelSword;
    public GameObject steelDagger;
    public GameObject steelClub;
    public GameObject steelStaff;
    public GameObject steelBow;
    public GameObject steelShield;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");

        var objectToSpawn = Random.Range(0, 3);

        if (objectToSpawn == 0)
        {
            ChooseWoodWeapon();
        }
        else if (objectToSpawn == 1)
        {
            ChooseIronWeapon();
        }
        else if (objectToSpawn == 2)
        {
            ChooseSteelWeapon();
        }

        //Debug.Log("Monster" + objectToSpawn);


    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChooseWoodWeapon()
    {
        var objectToSpawn = Random.Range(0, 5);

        if (objectToSpawn == 0)
        {
            var woodSwordSpawned = (GameObject)Instantiate(woodSword, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var woodDaggerSpawned = (GameObject)Instantiate(woodDagger, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var woodClubSpawned = (GameObject)Instantiate(woodClub, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 3)
        {
            var woodStaffSpawned = (GameObject)Instantiate(woodStaff, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 4)
        {
            var woodBowSpawned = (GameObject)Instantiate(woodBow, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 5)
        {
            var woodShieldSpawned = (GameObject)Instantiate(woodShield, transform.position, transform.rotation);
        }
    }

    void ChooseIronWeapon()
    {
        var objectToSpawn = Random.Range(0, 5);

        if (objectToSpawn == 0)
        {
            var ironSwordSpawned = (GameObject)Instantiate(ironSword, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var ironDaggerSpawned = (GameObject)Instantiate(ironDagger, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var ironClubSpawned = (GameObject)Instantiate(ironClub, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 3)
        {
            var ironStaffSpawned = (GameObject)Instantiate(ironStaff, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 4)
        {
            var ironBowSpawned = (GameObject)Instantiate(ironBow, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 5)
        {
            var ironShieldSpawned = (GameObject)Instantiate(ironShield, transform.position, transform.rotation);
        }
    }

    void ChooseSteelWeapon()
    {
        var objectToSpawn = Random.Range(0, 5);

        if (objectToSpawn == 0)
        {
            var steelSwordSpawned = (GameObject)Instantiate(steelSword, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 1)
        {
            var steelDaggerSpawned = (GameObject)Instantiate(steelDagger, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 2)
        {
            var steelClubSpawned = (GameObject)Instantiate(steelClub, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 3)
        {
            var steelStaffSpawned = (GameObject)Instantiate(steelStaff, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 4)
        {
            var steelBowSpawned = (GameObject)Instantiate(steelBow, transform.position, transform.rotation);
        }
        else if (objectToSpawn == 5)
        {
            var steelShieldSpawned = (GameObject)Instantiate(steelShield, transform.position, transform.rotation);
        }
    }
}
