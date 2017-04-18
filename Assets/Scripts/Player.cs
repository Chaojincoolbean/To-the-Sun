using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(AudioSource))]
public class Player : MonoBehaviour {
	public Rigidbody2D rb;
	public GameObject pin;
	public GameObject TimeMesh;
	public float score;
	bool hasspaced;


	float x,y,z;
	float timer;
	float planettimer;



	// Use this for initialization

	void Start () {
		
		hasspaced = false;
		timer = 0f;
		planettimer = 1;


	}


	// Update is called once per frame

	void Update () {

		timer = timer + Time.deltaTime * planettimer;

		PlayerPrefs.SetFloat ("timer", timer);

		x = this.gameObject.transform.position.x;
		y = this.gameObject.transform.position.y;
		z = this.gameObject.transform.eulerAngles.z;

		BorderCheck ();

		if(Input.GetKey(KeyCode.UpArrow)){
			z = z + 1f;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			z = z - 1f;
		}
			
		this.gameObject.transform.rotation = Quaternion.Euler (0, 0, z);

		Vector3 direction = pin.gameObject.transform.position - this.gameObject.transform.position;

		if(hasspaced == false){
		if(Input.GetKeyDown(KeyCode.Space)){
			rb.isKinematic = false;
			

			rb.AddForce(direction.normalized * 8f ,ForceMode2D.Impulse);
				//hasspaced = true;
		}
	}

		rb.AddForce(direction.normalized * 0.5f ,ForceMode2D.Force);

		TimeMesh.GetComponent<TextMesh> ().text = "Time: " + (int)timer;

	}
		

	void OnTriggerStay2D(Collider2D col){

		if (col.gameObject.name == "jupiter") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 200f, ForceMode2D.Force);
			planettimer = 0.1f;
		}

		if (col.gameObject.name == "saturn") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 180f, ForceMode2D.Force);
			planettimer = 0.2f;
		}

		if (col.gameObject.name == "neptune") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 160f, ForceMode2D.Force);
			planettimer = 0.5f;
		}

		if (col.gameObject.name == "uranus") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 140f, ForceMode2D.Force);
			planettimer = 0.8f;
		}

		if (col.gameObject.name == "earth") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 120f, ForceMode2D.Force);
			planettimer = 1f;
		}

		if (col.gameObject.name == "venus") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 100f, ForceMode2D.Force);
			planettimer = 2f;
		}

		if (col.gameObject.name == "mars") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 60f, ForceMode2D.Force);
			planettimer = 3f;
		}

		if (col.gameObject.name == "mercury") {
			Vector3 direction = col.gameObject.transform.position - this.gameObject.transform.position;
			rb.AddForce (direction.normalized * 40f, ForceMode2D.Force);
			planettimer = 4f;
		}
			
	}

	void OnTriggerExit2D(Collider2D col){
		planettimer = 1f;

	}




	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.name == "sun") {
			score = timer;
			SceneManager.LoadScene (2);
		}

	}

	void BorderCheck(){
		
		if (y > 12f) {
			y = 12f;
		}
		if (y < -12f) {
			y = -12f;
		}
		if (x > 22f) {
			x = 22f;
		}
		if (x < -22f) {
			x = -22f;
		}
	}


//	void GameOver(){
//
//		if (m >= 50) {
//			SceneManager.LoadScene (2);
//		}
//		if (m < 50) {
//			SceneManager.LoadScene (3);
//		}
//
//	}
//
//		
//
//	IEnumerator Wait1(){
//		yield return new WaitForSeconds (5);
//		c = 0;
//		mainCamera.transform.rotation = Quaternion.Euler (0, 0, 0);
//		this.gameObject.transform.GetChild(0).GetComponent<Animator> ().Play("player_animation");
//	}
//
//	IEnumerator Wait2(){
//		yield return new WaitForSeconds (2);
//		c = 0;
//		this.gameObject.transform.GetChild(0).GetComponent<Animator> ().Play("player_animation");
//	}
}
