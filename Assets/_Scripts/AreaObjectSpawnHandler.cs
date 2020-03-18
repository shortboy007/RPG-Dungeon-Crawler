using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaObjectSpawnHandler : MonoBehaviour
{
    public GameObject spawnObject;
    public int spawnObjects;
    public GameObject spawnObject2;
    public int spawnObjects2;
    public GameObject spawnObject3;
    public int spawnObjects3;
    //public float range;
    public float height = 10f;

    public GameObject area;

    // Use this for initialization
    void Start()
    {

        CreateObjects(spawnObjects, spawnObject);
        CreateObjects(spawnObjects2, spawnObject2);
        CreateObjects(spawnObjects3, spawnObject3);

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O))
        {
            CreateObjects(spawnObjects, spawnObject);
            CreateObjects(spawnObjects2, spawnObject2);
            CreateObjects(spawnObjects3, spawnObject3);
        }
    }

    void CreateObjects(int numObjects, GameObject objectType)
    {
        for (int i = 0; i < numObjects; i++)
        {
            /*GameObject objects = Instantiate(objectType, new Vector3(Random.Range(-range, range), 1f,
                                                               Random.Range(-range, range)) + transform.position,
                                           Quaternion.Euler(new Vector3(0f, Random.Range(0f, 360f), 0f)));*/

            GameObject objects = Instantiate(objectType, new Vector3(Random.Range(-transform.localScale.z, transform.localScale.z), height,
                                                                  Random.Range(-transform.localScale.x, transform.localScale.x)) + transform.position,
                                              Quaternion.Euler(new Vector3(0f, Random.Range(0f, 360f), 0f)));
        }
    }

    public void ResetArea()
    {
    }
}
