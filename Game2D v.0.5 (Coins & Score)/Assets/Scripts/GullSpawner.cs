using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GullSpawner : MonoBehaviour {

	float t,t2,tSpawn,tSpawn2;

	public static GullSpawner gullSpawner;
	//The Prefabs to Spawn the enemies
	public GameObject GullPrefab;
	public GameObject EaglePrefab;
	//public float vel;
	// transform variables to access both players
	private Transform player;
	private Transform player2;

	// Use this for initialization
	void Start () {
		//vel = -8f;
		//initialize the time it takes to spawn an enemy of each kind
		tSpawn = 5.5f;
		tSpawn2 = 8f;
		// Link each transform variable to the transform of each player
		player = GameObject.Find ("Player").transform;
		player2 = GameObject.Find ("Player2").transform;
	}
	/*
	public float getVel(){
		return vel;
	}
	*/
	// Update is called once per frame
	void Update () {
		//time elapsed for each spawn
		t += Time.deltaTime;
		t2 += Time.deltaTime;

		//if the time for spawn is reached a new enemy will be spawned with a random Y pos between in 1.5 and
		//8 units above the average Y pos of the two players. The X position will be in the far left or far right of the camera depending 
		//the type of enemy 

		if (t >= tSpawn) {
			t = 0;
			//vel -= 0.3f;
			tSpawn -= 0.001f; 
			float x = ((player.position.x+player2.position.x)/2)+11f;
			float y = Random.Range (((player.position.y+player2.position.y)/2)-2f, ((player.position.y+player2.position.y)/2)+4f);
			Vector3 pos = new Vector3 (x,y,0);
			Quaternion rot = new Quaternion();
			Instantiate(GullPrefab, pos, rot);
		}

		if (t2 >= tSpawn2) {
			t2 = 0;
			tSpawn2 -= 0.002f; 
			float x2 = ((player.position.x+player2.position.x)/2)-11f;
			float y2 = Random.Range (((player.position.y+player2.position.y)/2)+1.5f, ((player.position.y+player2.position.y)/2)+8f);
			Vector3 pos2 = new Vector3 (x2,y2,0);
			Quaternion rot2 = new Quaternion();
			Instantiate(EaglePrefab, pos2, rot2);
		}
	}
	//void OnBecameInvisible(){}
}
