using UnityEngine;

public class playerCollision : MonoBehaviour
{

    public Playermovement movement;

    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }

}
