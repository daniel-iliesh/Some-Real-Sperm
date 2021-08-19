using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashObstacle : MonoBehaviour {

public float forceStrength = 0.5f;
public GameObject player;

private Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update() 
    {
        transform.LookAt(player.transform);
    }


    private void OnTriggerEnter(Collider other) {

        if (other.tag == "Player") {

            animator.enabled = false;
            Debug.Log("Collision with Player!");
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forceStrength, ForceMode.Impulse);

        }
    }
}
    
        
