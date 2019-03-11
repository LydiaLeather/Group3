using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGremlin : MonoBehaviour {

	//public static MoveGremlin moveGremlin;
	Rigidbody2D rb;
	//Prefab for fire attack
	public GameObject Fireballprefab;
	Animator an;
	//Bools to chech for double jump and the orientation of the sprite
	bool jump1, jump2, OnRight;
	//public float Ypos;
	// Use this for initialization
	void Start () {
		rb = this.GetComponent<Rigidbody2D> (); 
		an = this.GetComponent<Animator> ();
		//Players start on the air
		an.SetBool ("OnGround",false);
		OnRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		
		float h = Input.GetAxis ("Horizontal");

		rb.AddForce(new Vector2(h, 0), ForceMode2D.Impulse);
		//rb.velocity = new Vector2((h*10), an.velocity.y);
		an.SetFloat ("speed",Mathf.Abs(h));

		//Ypos = rb.transform.position.y;

		if (Input.GetKeyDown ("down") && !this.an.GetCurrentAnimatorStateInfo(0).IsName("slide")){
			an.SetBool ("slide",true);
		}
			else {
				an.SetBool ("slide",false);
			}

		if (Input.GetKeyDown ("up") && jump2) {
			rb.AddForce(new Vector2 (0, 22f), ForceMode2D.Impulse);

			an.SetBool ("OnGround",false);
			an.SetTrigger ("jump");

			if (jump1==false) {
				jump2 = false;
			}
			jump1 = false;
		}
		//check the direction taken to flip or not the sprite
		if (h < 0) {
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;
			OnRight = false;
		} else if (h >0 ){
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;
			OnRight = true;
		}

		if (Input.GetKeyDown ("l")){
			FireBall();
		}
	}


	//Function to perform fire attack
	public void FireBall(){
		if (OnRight) {
			GameObject tmp = (GameObject)Instantiate (Fireballprefab, transform.position+new Vector3(2,0,0), Quaternion.identity);
			tmp.GetComponent<Fireball> ().setDirection (Vector2.right);
		} 
		else {
			GameObject tmp = (GameObject)Instantiate (Fireballprefab, transform.position-new Vector3(2,0,0), Quaternion.Euler(new Vector3(0, 0, -180)));
			tmp.GetComponent<Fireball> ().setDirection (Vector2.left);
		}
	}

	//if the player hits the ground the bool variables are reset to true
	private void OnCollisionEnter2D(Collision2D collision){
		if (collision.transform.tag == "ground") {
			jump1 = true;
			jump2 = true;
			an.SetBool ("OnGround",true);
			//an.SetTrigger ("OnGround");
		}
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
