/*Script has to be attach to a Camera, to make it works, you need to have an object with a tag "player" to follow  */
/*Smootitude change the camera speed, more the value is close to 0, more the camera stick to the player*/
/*The positionY axis can be locked*/

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    private Vector2 velocity;
    
    public float smootitudeY;   //Speed on Yaxis
    public float smootitudeX;   //Speed on Xaxis    
    public bool yChange;        //Enable the camera to move on the Yaxis   
    public float yHeight;       //Set the height of the camera if it's locked on    
    public GameObject player;   //Object(player) that the camera follows

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");

    }


    void FixedUpdate()
    {

        float posX = Mathf.SmoothDamp(transform.position.x, player.transform.position.x, ref velocity.x, smootitudeX);
        float posY = Mathf.SmoothDamp(transform.position.y, player.transform.position.y, ref velocity.y, smootitudeY);

        if (yChange)
        {
            transform.position = new Vector3(posX, posY, transform.position.z);
            Debug.Log("transform with Y");
        }
        else
        {
            transform.position = new Vector3(posX, yHeight, transform.position.z);
            Debug.Log("transform without Y");
        }



    }
}
