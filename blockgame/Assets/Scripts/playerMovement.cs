using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    // This is used to create a reference to the rigid body component
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 200f;
    
	// Use this for initialization
    // Draws the first frame when the game started and call this function 
	void Start () {
        Debug.Log("Game Started");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        // we are adding a force to move the object cube forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
		

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
