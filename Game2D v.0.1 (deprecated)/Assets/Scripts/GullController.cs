using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GullController : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(-8f*Time.deltaTime,0,0);
		if (gameObject.transform.position.x < -11) {
			Destroy(transform.parent.gameObject);
		}
	}
	private void OnTriggerEnter2D(Collider2D collision){
		//gameObject.SetActive(false);
		ScoreCounter.scoreCounter.IncreaseScore(1);
		Destroy(transform.parent.gameObject);
	}
}
