using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerIndy : MonoBehaviour {

    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;
    public bool yChange;
    public GameObject player;


    void Start () {

        player = GameObject.FindGameObjectWithTag("Player");

	}
	
	
	void FixedUpdate () {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smoothTimeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smoothTimeY);

        if(yChange)
        {
            transform.position = new Vector3(posX, posY, transform.position.z);
            Debug.Log("transform with Y");
        }
        else
        {
            transform.position = new Vector3(posX, 3f, transform.position.z);
            Debug.Log("transform without Y");
        }
            


    }
}
