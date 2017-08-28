using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	[Header("Player Speed limit")]
	public float speed;
	[Header("Player Jump force")]
	public float jump;
    public AudioClip jumpSound;

	private Rigidbody2D body;
	private bool readyToJump;
    private AudioSource source;

	void Awake(){
		body = this.GetComponent<Rigidbody2D> ();
        source = GetComponent<AudioSource>();
	}

	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		transform.Translate ((new Vector2(x, 0) * speed));


		if (Input.GetButtonDown ("Jump") && readyToJump) {
			body.AddForce (new Vector2 (0, jump));
			readyToJump = false;

            source.PlayOneShot(jumpSound);
            
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "floor") {
			readyToJump = true;
		}
	}
}