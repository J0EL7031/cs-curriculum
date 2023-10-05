using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     float xspeed;
     float xdirection;
     float xvector;
     float yspeed;
     float ydirection;
     float yvector;
     public bool inCaves;




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
        yvector =ydirection * yspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, y:yvector, z: 0f);
    }
}

