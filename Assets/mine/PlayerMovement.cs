using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     float wspeed;
     float xdirection;
     float xvector;




    // Start is called before the first frame update
    void Start()
    {
        wspeed = 5f;
    }


    // Update is called once per frame
    void Update()
    {

        xdirection = Input.GetAxis("Horizontal");
        xvector = xdirection * wspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, y: 0f, z: 0f);
    }
}

