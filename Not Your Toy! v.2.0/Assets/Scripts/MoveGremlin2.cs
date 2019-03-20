using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveGremlin2 : MonoBehaviour {

    //the reference to the other player
    public Rigidbody2D otherGuy;

    //public static MoveGremlin moveGremlin;
    Rigidbody2D rb;
	//Audios for the player
	public AudioSource Jump;
    public AudioSource Death;
    public AudioSource FireAttack;
	//Prefab for fire attack
	public GameObject Fireballprefab;

    public Text gameOverText;
    bool canRestart;

    //reference to the score text
    public Text countText;

    Animator an;
	//Bools to chech for double jump and the orientation of the sprite
	bool jump1, jump2, OnRight;
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


        //if player falls below y == -10, the game ends and can be restarted
        if (canRestart == false && (rb.transform.position.y < -10 || rb.gameObject.tag == "TouchedDragon"))
        {
            gameOverText.text = "Game over!\nScore: " + int.Parse(countText.text) + "\nPress 'R' to restart";
            otherGuy.gameObject.tag = "TouchedDragon";
            canRestart = true;
            Death.Play();
        }
        //restart itself
        if (canRestart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel(Application.loadedLevel);
#pragma warning restore CS0618 // Type or member is obsolete
            }
            else
            {
                return;
            }
        }


        //float fleft = Input.GetKey ("f");
        //float hright = Input.Getkey ("h");
        float h;
		if (Input.GetKey ("h")){
			h=1;
		}
		else{ 
			if (Input.GetKey ("f")){
				h=-1;
			}
			else {
					h = 0;		
			}
		}
 		
		rb.AddForce(new Vector2(h, 0), ForceMode2D.Impulse);
		//rb.velocity = new Vector2((h*10), an.velocity.y);
		an.SetFloat ("speed",Mathf.Abs(h));

		if (Input.GetKeyDown ("g") && !this.an.GetCurrentAnimatorStateInfo(0).IsName("slide")){
			an.SetBool ("slide",true);
		}
			else {
				an.SetBool ("slide",false);
			}

		if (Input.GetKeyDown ("t") && jump2) {
			Jump.Play ();
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
		if (Input.GetKeyDown ("y")){
			FireAttack.Play ();
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

    /*
        void OnBecameInvisible(){
            //Destroy (gameObject);
        }
        */

    //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Coin"))
        {

            //... then set the other object we just collided with to inactive.
            other.gameObject.SetActive(false);
            //Destroy(other.gameObject);
            //Add one to the current value of our count variable.
            countText.text = (int.Parse(countText.text) + 1).ToString();

            //Update the currently displayed count by calling the SetCountText function.
            //SetCountText();
        }
    }
}

