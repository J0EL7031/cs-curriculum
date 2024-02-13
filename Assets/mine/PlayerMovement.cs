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
    public bool onGround1;
    public bool onGround2;

    public int jumps;

    public int ray0;
    public int ray1;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();

        onGround = false;

        jumps = 0;

        //ray0 = transform.position - 1;
            
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

        if (onGround)
        {
            jumps = 0;
        }

        yvolocity = 0;

            if (inCaves)
            {
                xdirection = Input.GetAxis("Horizontal");
                xvector = xdirection * xspeed * Time.deltaTime;

                onGround1 = (Physics2D.Raycast((transform.position + new Vector3(0.35f,0,0)),Vector2.down, 1f));
                
                onGround2 = (Physics2D.Raycast((transform.position + new Vector3(-0.35f,0,0)),Vector2.down, 1f));
                   
                Debug.DrawRay((transform.position + new Vector3(0.35f,0,0)), Vector2.down, Color.red);
                
                Debug.DrawRay((transform.position + new Vector3(-0.35f,0,0)), Vector2.down, Color.blue);
                
                
                transform.position = transform.position + new Vector3(xvector, y: 0, z: 0f);
                
                hud.playerx = gameObject.transform.position.x;
                hud.playery = gameObject.transform.position.y;
                
                if (onGround1)
                {
                    onGround = true;
                }
                
                if (onGround2)
                {
                    onGround = true;
                }

                if (onGround1 != true)
                {
                    if (onGround1 == onGround2)
                    {
                        onGround = false;
                    }
                }
                    
                if (Input.GetKeyDown(KeyCode.UpArrow))
                { 
                    
                    if (onGround != true)
                                     {
                                         if (jumps < 2)
                                         {
                                             jumps = 2;
                                                 
                                             RB.AddForce(Vector3.up * 350);
                                         }
                                     }
                    if (onGround)
                        {
                            

                                jumps = 1;
                                
                                RB.AddForce(Vector3.up * 300);

                                onGround = false;
                            

                        }

                   

                }
                
            }
            
            
        
    }
}