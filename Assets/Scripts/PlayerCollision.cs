// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public CarMovement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if( collisionInfo.collider.tag == "Obstacle" )
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
