using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MannirAnimate : MonoBehaviour {

	GameObject go;
	float angle = 360.0f; // Degree per time unit
	float time = 1.0f; // Time unit in sec
	Vector3 axis = Vector3.up; // Rotation axis, here it the yaw axis

	// Use this for initialization
	void Start () {


		
	}

	// Update is called once per frame
	void Update () {
//		transform.Translate(0, -2.5f * Time.deltaTime, 0, Space.World);
		transform.Rotate(0, angle * Time.deltaTime / time, 0, Space.World);
//		go.GetComponent<Transform>().RotateAround(Vector3.zero, axis, angle * Time.deltaTime / time);
		
	}
}
