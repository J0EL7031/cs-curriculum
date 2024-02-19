using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class sideplatform3 : MonoBehaviour
{

    public float rightLimit;
    public float leftLimit;

    public float speed;

    public int direction;

    public bool on;

    // Start is called before the first frame update
    void Start()
    {
        speed = 15;

        direction = 1;

        rightLimit = 94;
        leftLimit = 52;
        
        on = false;
    }

    // Update is called once per frame
    void Update()
    {   if (on)
        {
            transform.position = gameObject.transform.position + new Vector3(speed * direction * Time.deltaTime,0,0);
            direction = -1;
            if (transform.position.x < leftLimit)
            {
                

                direction = 0;
                
                
            }
        }

        if (on != true)
        {
            
            transform.position = gameObject.transform.position + new Vector3(speed * direction * Time.deltaTime, 0, 0);

            direction = 1;
            
            if (transform.position.x > rightLimit)
            {
                direction = 0;
                
            }

        }

        // transform.position = gameObject.transform.position + new Vector3(speed * direction * Time.deltaTime,0,0);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(transform);

            on = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(null);
            
            on = false;
        }
    }
}