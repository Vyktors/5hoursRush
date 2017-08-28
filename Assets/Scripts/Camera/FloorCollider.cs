using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "floor")
        {
            Debug.Log("detect floor");

            this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;

            
        }

    }
    /*
    void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Quit Floor");
        this.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
    }
    */
}
    
