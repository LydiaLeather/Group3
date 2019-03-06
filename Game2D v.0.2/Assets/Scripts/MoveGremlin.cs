using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGremlin : MonoBehaviour {

	//public static MoveGremlin moveGremlin;
	Rigidbody2D rb;
	bool jump1, jump2;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> (); 
		
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		rb.AddForce(new Vector2(h, 0), ForceMode2D.Impulse);

		if (Input.GetKeyDown ("up") && jump2) {
			rb.AddForce(new Vector2 (0, 22f), ForceMode2D.Impulse);

			if (jump1==false) {
				jump2 = false;
			}
			jump1 = false;
		}
		if (h > 0) {
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;
		} else {
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
		}
	}



	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.transform.tag == "ground") {
			jump1 = true;
			jump2 = true;
		}
	}
}
