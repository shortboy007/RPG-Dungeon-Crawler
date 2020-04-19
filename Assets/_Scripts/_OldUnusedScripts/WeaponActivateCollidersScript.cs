using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivateCollidersScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.K))
        {
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
        else
        {
            this.GetComponent<CapsuleCollider>().enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<CapsuleCollider>().enabled = true;
        }
        else
        {
            this.GetComponent<CapsuleCollider>().enabled = false;
        }
    }
}
