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
    private Rigidbody2D RB;
    public bool inCaves;

    public float yvolocity;

    public HUD hud;

    public bool onGround;
    

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        
        xspeed = 5f;
        yspeed = 5f;
        if (inCaves)
        {
            yspeed = 0;
        }

        yvolocity = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if (inCaves != true)
        {
            xdirection = Input.GetAxis("Horizontal");
            xvector = xdirection * xspeed * Time.deltaTime;
            ydirection = Input.GetAxis("Vertical");
            yvector = ydirection * yspeed * Time.deltaTime;
            transform.position = transform.position + new Vector3(xvector, y: yvector, z: 0f);
            hud.playerx = gameObject.transform.position.x;
            hud.playery = gameObject.transform.position.y;
        }



        yvolocity = 0;

            if (inCaves)
            {
                xdirection = Input.GetAxis("Horizontal");
                xvector = xdirection * xspeed * Time.deltaTime;

                if (Physics2D.Raycast(transform.position, Vector2.down, 1f))
                {
                    onGround = true;
                }
                
                
                transform.position = transform.position + new Vector3(xvector, y: 0, z: 0f);
                hud.playerx = gameObject.transform.position.x;
                hud.playery = gameObject.transform.position.y;
                
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    if (onGround)
                        {
                            onGround = false;
                            
                            RB.AddForce(Vector3.up * 250);
                            
                        }

                }

                
            }
            
        
    }
}