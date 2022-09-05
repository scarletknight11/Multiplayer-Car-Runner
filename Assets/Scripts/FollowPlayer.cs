using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;
    public float Yoffset;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 move = new Vector3(0.07f, Yoffset, -12f);
        transform.position = player.transform.position + move; 
    }
}
