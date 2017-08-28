
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {


    private Vector2 velocity;

    public float smootitudeY;
    public float smootitudeX;
    public bool yChange;
    public float yHeight;
    public GameObject player;


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
