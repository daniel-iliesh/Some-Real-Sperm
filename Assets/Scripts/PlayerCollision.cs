using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    void OnCollisionEnter (Collision colisionInfo)
    {
        if (colisionInfo.collider.tag == "Obstacle") {
        Debug.Log(colisionInfo.collider.tag);
        movement.enabled = false;
        FindObjectOfType<GameManager>().EndGame();
        }
    }
}
