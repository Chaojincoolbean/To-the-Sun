using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackward: MonoBehaviour {

	public float n;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.back * n * Time.deltaTime);


	}
}
