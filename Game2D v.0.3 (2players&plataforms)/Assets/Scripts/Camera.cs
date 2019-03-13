using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {
	
	// transform variables to access both players
	private Transform player;
	private Transform player2;

	// Use this for initialization
	void Start () {
		// Link each transform variable to the transform of each player
		player = GameObject.Find ("Player").transform;
		player2 = GameObject.Find ("Player2").transform;

	}

	void LateUpdate(){
		//The camera will be positioned exactly between the two players
		transform.position = new Vector3 ((player.position.x+player2.position.x)/2, (player.position.y+player2.position.y)/2, -10);
	}


}
