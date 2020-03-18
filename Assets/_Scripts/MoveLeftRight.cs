using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour
{

    public float speed = 20f;

    public float leftAndRightEdge = 100f;
    public float otherEdge = 100f;

    public float chanceToChangeDirections = 0.01f;

    public float secondsBetweenSpawns = 1f;

    void Start()
    {
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
        Vector3 pos2 = transform.position;
        pos2.z += speed * Time.deltaTime;
        transform.position = pos2;

        if (pos2.z < -otherEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos2.z > otherEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
    void FixedUpdate()
    {
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}