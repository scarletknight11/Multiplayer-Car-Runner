using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

    public float speed = 5.0f;
    public float turnspeed = 25.0f;
    //private variables
    private float turnHorizontal;
    private float forward;

    // Update is called once per frame
    void Update()
    {
        //Input controls
        turnHorizontal = Input.GetAxisRaw("Horizontal2");
        forward = Input.GetAxisRaw("Vertical2");
        // Move the vehicle forward
        transform.Translate(Vector3.forward * speed * forward * Time.deltaTime);
        // Turn the vehicles
        transform.Rotate(Vector3.up, turnspeed * turnHorizontal * Time.deltaTime);
    }
}
