using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{ 
    public Transform target;
    // public float smoothSpeed = 10f;
    public float offset;
    public float rotationOnXAxis = 20f;
    public Vector3 cameraPosition;


    // public GameObject player;
    // public float cameraDistance = 10.0f;
    // public float rotationOnXAxis = 13f;

    private void Start() {
        transform.Rotate(rotationOnXAxis, 0, 0 );
    }

    void FixedUpdate ()
    {
        //SMOOTH CAMERA FOLLOW
        // Vector3 desiredPosition = target.position + offset;
        // Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        // transform.position = smoothedPosition;
        
        cameraPosition.z = target.position.z + offset;
        transform.position = cameraPosition;
        

        // transform.position = player.transform.position - player.transform.forward * cameraDistance;
        // transform.LookAt (player.transform.position);
        // transform.position = new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z);
        // transform.Rotate(rotationOnXAxis, 0, 0 );
    }


}
