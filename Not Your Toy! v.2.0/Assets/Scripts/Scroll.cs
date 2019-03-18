using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {
	Material material;
	// transform variables to access both players
	private Transform player;
	private Transform player2;
	public float speedScroll = 0.02f;
	Vector2 offset;
	// Use this for initialization
	void Start () {
		// Link each transform variable to the transform of each player
		player = GameObject.Find ("Player").transform;
		player2 = GameObject.Find ("Player2").transform;
		//vector for the offset
		offset = new Vector2 (speedScroll, 0);
	}

	private void Awake(){
		material = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
		
		//The material with the background moves constantly
		material.mainTextureOffset += offset * Time.deltaTime;

	}

	void LateUpdate(){
		//the background also has to follow the average position of the two players
		transform.position = new Vector3 ((player.position.x+player2.position.x)/2, (player.position.y+player2.position.y)/2 , 5);

	}
}
