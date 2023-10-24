using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    float xspeed;
    float xdirection;
    float xvector;
    float yspeed;
    float ydirection;
    float yvector;
    public bool inCaves;
    public float playerx;

    

    // Start is called before the first frame update
    void Start()
    {
        xspeed = 5f;
        yspeed = 5f;
        if (inCaves)
        {
            yspeed = 0;
        }
    }


    // Update is called once per frame
    void Update()
    {

        xdirection = Input.GetAxis("Horizontal");
        xvector = xdirection * xspeed * Time.deltaTime;
        ydirection = Input.GetAxis("Vertical");
        yvector = ydirection * yspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, y: yvector, z: 0f);
        playerx = transform.position.x;
    }
}