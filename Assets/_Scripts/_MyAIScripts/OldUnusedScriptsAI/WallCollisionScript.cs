using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollisionScript : MonoBehaviour
{
    public int walkSpeed = 5;

    void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Civilian")
        {
            if (collision.gameObject.tag == "WOF")
            {
                collidedWith.transform.position -= Vector3.MoveTowards(transform.position,
                collidedWith.transform.position, Time.deltaTime * walkSpeed);
                Debug.Log("CloseToWOF");
            }
            /*if (collision.gameObject == wanderObjectBackward)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                wanderObjectForward.transform.position, Time.deltaTime * walkSpeed);
                Debug.Log("CloseToWOB");
            }
            if (collision.gameObject == wanderObjectRight)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                wanderObjectLeft.transform.position, Time.deltaTime * walkSpeed);
                Debug.Log("CloseToWOR");
            }
            if (collision.gameObject == wanderObjectLeft)
            {
                transform.position = Vector3.MoveTowards(transform.position,
                wanderObjectRight.transform.position, Time.deltaTime * walkSpeed);
                Debug.Log("CloseToWOL");
            }*/
        }
    }
}
