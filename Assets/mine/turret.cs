using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

public class Turret : MonoBehaviour
{
    public bool inRange;

    private float step;
    private Transform target;
    private float cooldown;
    private float speed;
    private GameObject player;
    private float cooldownTimer;
    
    public GameObject turret_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
       
        cooldown = 1;
        cooldownTimer = 0;
            

        speed = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
        cooldownTimer -= Time.deltaTime;
        if (cooldownTimer < 0)
        {
            if (inRange)
            {
                GameObject clone;
                
                clone = Instantiate(turret_Projectile, transform.position + new Vector3(0,0.4898863f,0), transform.rotation);
               // clone.transform.position = Vector3.MoveTowards(clone.transform.position, target.position, step);
                    
                cooldownTimer = cooldown;
                

               
            }
        }
    }
        
    

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                player = other.gameObject;
                inRange = true;
            }
        
       
        }
        
        void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                player = other.gameObject;
                inRange = false;
            }
        
       
        }

}
    
