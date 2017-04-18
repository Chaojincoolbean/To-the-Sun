using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setresolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
//		float aspect = Screen.width / Screen.height;
//		float desiredAspect = 1280.0f / 720;

//		float difference = aspect / desiredAspect;
		Screen.SetResolution (1280, 720, true); 
		Camera.main.rect = new Rect (0, 0.05f, 1.0f, 1.0f - 0.05f);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
