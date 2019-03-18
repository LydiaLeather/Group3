using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	private float speed = 8;
	Rigidbody2D rb;
	private Vector2 dir;
	private float time;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = dir * speed;
		time += Time.deltaTime;
		if (time >= 5) {
			Destroy (gameObject);
		}
	}

	public void setDirection(Vector2 dir){
		this.dir = dir;
	}

	//public void addxpos(float x){}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
