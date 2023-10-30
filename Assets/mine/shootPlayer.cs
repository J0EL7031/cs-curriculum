using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class shootPlayer : MonoBehaviour
{
    public HUD hud;
    public float fireX;
    
    // Start is called before the first frame update
    void Start()
    {
        fireX = gameObject.transform.position.x;
        
        
    }

    // Update is called once per frame
    void Update()
    {
    //    transform.Rotate();
        
        
        if (hud.playerx > fireX);
        {
            fireX += 1;
        }

    }
    
}

