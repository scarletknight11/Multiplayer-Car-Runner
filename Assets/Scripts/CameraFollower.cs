using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour {

    public GameObject follow;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0, offset, -3.4f);
        transform.position = follow.transform.position + move;
    }
}
