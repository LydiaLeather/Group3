using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

	private float speed = 8;
	Rigidbody2D rb;
	private Vector2 dir;

	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> ();

	}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = dir * speed;
	}

	public void setDirection(Vector2 dir){
		this.dir = dir;
	}

	//public void addxpos(float x){}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
