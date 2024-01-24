using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMovement : MonoBehaviour
{
    float xspeed;
    float xdirection;
    float xvector;
    float yspeed;
    float ydirection;
    float yvector;
    public bool inCaves;

    public HUD hud;
    

    // Start is called before the first frame update
    void Start()
    {
        
        xspeed = 5f;
        yspeed = 0;
        
    }


    // Update is called once per frame
    void Update()
    {
        
        xdirection = Input.GetAxis("Horizontal");
        xvector = xdirection * xspeed * Time.deltaTime;
        ydirection = Input.GetAxis("Vertical");
        yvector = ydirection * yspeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, y: yvector, z: 0f);
        hud.playerx = gameObject.transform.position.x;
        hud.playery = gameObject.transform.position.y;

        if (Input.GetKeyDown(KeyCode.K))
        {
            transform.position = transform.position + new Vector3(0, 100, 0);
        }
        
    }
}
