using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiseAndLowerScript : MonoBehaviour {

	Vector3 startPosition;
    public int speed = 10;

	// Use this for initialization
	void Start () {
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float x = startPosition.x;
		float y = speed * Mathf.Sin (Time.timeSinceLevelLoad) + startPosition.y;
		float z = startPosition.z;
		transform.position = new Vector3 (x, y, z);
	}
}
//Time.timeSinceLevelLoad
//Mathf.Abs  rise
//Mathf.Ceil slowly rise by increments smallest int >= f
//Mathf.Cos,Sin rise and lower
//Mathf.Exp rise quickly
//Mathf.Floor slowly rise, faster than Ceil by increments  largest int <=f
//Mathf.GammaToLinearSpace rise quickly
//Mathf.InverseLerp Moves away from target? Lerp moves towards target
//Mathf.MoveTowards Moves towards a target
//Mathf.Sqrt slowly rise slower than Exp and GTLS
//Mathf.Tan rise and appear at starting location to rise again