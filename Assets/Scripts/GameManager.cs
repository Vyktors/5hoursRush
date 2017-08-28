/* THIS SCRIPT IS REQUIRED FOR GAMELOOP
 * this script is responsible to give points to players
 * and set the end scene if everyone dies
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player{
	public GameObject bodyGameObject{ get; private set;}
	public int score{ get; private set; }
	public Player(GameObject playerBody){
		score = 0;
		bodyGameObject = playerBody;
	}
}

public class GameManager : MonoBehaviour {
	public GameObject playerPrefab; 
	public Camera GameCamera;
	public Vector3 spawn;

	private List<Player> players;

	public void SpawnPlayer(){

		GameObject currentGameObject = GameObject.Instantiate (playerPrefab, spawn, Quaternion.identity);
		GameCamera.GetComponent<CameraController> ().player = currentGameObject;
		//players.Add (new Player (currentGameObject)); 

	}

	// Use this for initialization
	void Start () {
		SpawnPlayer ();
	}
}
