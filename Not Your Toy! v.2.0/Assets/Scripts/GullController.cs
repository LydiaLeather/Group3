﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class GullController : MonoBehaviour {

	// transform variables to access both players
	private Transform player;
	private Transform player2;
	private GameObject playerG;
	private GameObject player2G;
	// Use this for initialization
	void Start () {
		// Link each transform variable to the transform of each player
		player = GameObject.Find ("Player").transform;
		player2 = GameObject.Find ("Player2").transform;
		playerG = GameObject.Find ("Player");
		player2G = GameObject.Find ("Player2");
	}
	
	// Update is called once per frame
	void Update () {
		//to exit the game
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}

		//the enemy moves constantly to the left
		gameObject.transform.Translate(-8.5f*Time.deltaTime,0,0);
		//If the enemy is out of camera it destroys itself
		if (gameObject.transform.position.x < ((player.position.x+player2.position.x)/2)-11f){
			Destroy(transform.parent.gameObject);
		}
	}

	//If the enemy is collisioned it is destroyed 
	//If the player hits the enemy the game ends
	private void OnTriggerEnter2D(Collider2D other){
		//gameObject.SetActive(false);
		ScoreCounter.scoreCounter.IncreaseScore(1);
		if ((other.gameObject.name == "Player") || other.gameObject.name == "Player2") {
            //here the game should end
            //Application.Quit();
            other.gameObject.tag = "TouchedDragon";

            //Destroy (playerG);
            //Destroy (player2G);
        }
        Destroy(transform.parent.gameObject);
	}
	void OnBecameInvisible(){
		//Destroy(transform.parent.gameObject);
		Destroy(gameObject);
	}
}
