using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public float timer;


	// Use this for initialization
	void Start () {

		timer = PlayerPrefs.GetFloat ("timer");
		Debug.Log (timer);

		this.gameObject.GetComponent<TextMesh> ().text = "Travel time: " + (int)timer;

	}
	
	// Update is called once per frame
	void Update () {



		
	}
}
