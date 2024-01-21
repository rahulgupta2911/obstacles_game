using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    
     void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacles")
        {
           GetComponent<PlayerMovement>().enabled = false;
           FindAnyObjectByType<GameManager>().EndGame();
           
        }
    }
}
