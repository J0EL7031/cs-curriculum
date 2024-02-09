using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sideplatform : MonoBehaviour
{

    public float rightLimit;
    public float leftLimit;

    public float speed;

    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8;

        direction = 1;

        rightLimit = 75;
        leftLimit = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftLimit)
        {
            direction = 1;
        }
        
        if (transform.position.x > rightLimit)
        {
            direction = -1;
        }

        

        transform.position = gameObject.transform.position + new Vector3(speed * direction * Time.deltaTime,0,0);
    }
}