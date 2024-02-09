using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upplaform2 : MonoBehaviour
{

    public float upLimit;
    public float downLimit;

    public float speed;

    public int direction;

    // Start is called before the first frame update
    void Start()
    {
        speed = 5;

        direction = 1;

        upLimit = 90;
        downLimit = 70;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < downLimit)
        {
            direction = 1;
        }
        
        if (transform.position.y > upLimit)
        {
            direction = -1;
        }

        

        transform.position = gameObject.transform.position + new Vector3(0,speed * direction * Time.deltaTime,0);
    }
}