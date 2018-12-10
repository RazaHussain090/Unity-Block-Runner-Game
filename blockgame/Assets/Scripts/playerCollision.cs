using UnityEngine;

public class playerCollision : MonoBehaviour {

    public playerMovement movement;
    
    // when ever any object collides these function is called
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obsticle")
        {
            movement.enabled = false;
            FindObjectOfType<gameManager>().EndGame();
        }
    }
}
