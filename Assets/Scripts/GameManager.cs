using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Renderer))]

public class GameManager : MonoBehaviour {

	public  List<GameObject> mushrooms;
	public GameObject player;
	GameObject Mushroom;
	GameObject newMushroom;
	float x;
	float y;
	float n;



	// Use this for initialization
	void Start () {
		
		//newMushroom = Resources.Load<GameObject>("mushroom1");
		x = 0f;
		y = 0f;

	}
	
	// Update is called once per frame
	void Update () {

		n++;

		if ((n%60) == 0) {
			
			CreateNewMushroom();

		}
				
	}

	void CreateNewMushroom(){
		
		x = Random.Range (-8.33f, 8.23f);
		y = Random.Range (-4.28f, 1.73f);

		if (x > player.transform.position.x- 2f && x < player.transform.position.x+ 2f) {
			//Debug.Log ("copyx");
			x = player.transform.position.x+ 2f;
		}

		if (y > player.transform.position.y- 2f && y < player.transform.position.y+ 2f) {
			//Debug.Log ("copyy");
			y = player.transform.position.y+ 2f;
		}



		newMushroom = mushrooms [Random.Range (0, mushrooms.Count)];
		//newMushroom = mushrooms[0];

		GameObject Mushroom = Instantiate (newMushroom,new Vector3 (x, y, 0) , Quaternion.identity) as GameObject;

		Destroy (Mushroom, 10f);

	}
		
}
