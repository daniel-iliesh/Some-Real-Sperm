using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowX : MonoBehaviour
{
    public Transform ObjectToFollow;
    public Vector3 offset;
    public Vector3 rotation;

    // Update is called once per frame
    void Update()
    {
        transform.position = ObjectToFollow.position + offset;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
