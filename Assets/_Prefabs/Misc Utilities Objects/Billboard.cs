using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour {

	public GameObject Camera;

	void Update () {
        transform.LookAt(Camera.transform);
    }
}
