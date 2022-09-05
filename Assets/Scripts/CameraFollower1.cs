using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower1 : MonoBehaviour {

    public GameObject follow;
    public float offset;

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(0.46f, offset, -12f);
        transform.position = follow.transform.position + move;
    }
}
