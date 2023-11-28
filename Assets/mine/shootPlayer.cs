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
        hud = GameObject.FindObjectOfType<HUD>();
        transform.Rotate(hud.playerx,hud.playery,0);

    }

    // Update is called once per frame
    void Update()
    {

        
        
    }
    
}

