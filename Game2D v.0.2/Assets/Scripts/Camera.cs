using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	private Transform player;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player").transform;
	}

	void LateUpdate(){
		transform.position = new Vector3 (player.position.x, player.position.y+1, -10);
	}


}
