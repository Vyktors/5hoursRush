using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	[Header("Player Speed limit")]
	public float speed;
	[Header("Player Jump force")]
	public float jump;

	private Rigidbody2D body;

	void Awake(){
		body = this.GetComponent<Rigidbody2D> ();
	}

	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal");
		if (Input.GetButton ("Jump")) {
			body.AddForce (new Vector2 (0, jump));
		}
		transform.Translate ((new Vector2(x, 0) * speed));
	}
}