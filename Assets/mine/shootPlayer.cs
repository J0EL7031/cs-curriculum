using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class shootPlayer : MonoBehaviour
{
    public float speed;
  
    private Vector3 target;
    
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindObjectOfType<PlayerMovement>().gameObject.transform.position;
        speed = 8;
       

    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, target, step);
        
        if (Vector3.Distance(transform.position, target) < 0.001f)
        {
            Destroy(gameObject);
        }


    }
    
}

