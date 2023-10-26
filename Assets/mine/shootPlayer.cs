using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class shootPlayer : MonoBehaviour
{
    public HUD hud;
    public float fireX;
    
    // Start is called before the first frame update
    void Start()
    {
        fireX = gameObject.transform.position.x;
        
        //transform.LookAt();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        if (hud.playerx > fireX);
        {
            fireX += 1;
        }

    }
    
}

