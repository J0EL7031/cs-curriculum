using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class shootPlayer : MonoBehaviour
{
    public float playerx;
    public float fireX;

    // Start is called before the first frame update
    void Start()
    {
        fireX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
       
        fireX = transform.position.x;
        
        if (playerx > transform.position.x);
        {
            fireX += 1;
        }

    }
}        