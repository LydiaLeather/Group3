using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public static ScoreCounter scoreCounter;
	public Text scoreText;
	int score = 0;

	public void IncreaseScore(int s){
		score += s;
		scoreText.text = score + "";
	}

	// Use this for initialization
	void Start () {
		scoreCounter = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
