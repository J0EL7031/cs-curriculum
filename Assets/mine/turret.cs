using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

public class Turret : MonoBehaviour
{
    public bool inRange;

    
    private float cooldown;
    private float speed;
    private GameObject player;
    
    public GameObject turret_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
       
        cooldown = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        cooldown -= Time.deltaTime;
        if (cooldown < 1)
        {
            if (inRange)
            {
                GameObject temp = Instantiate(turret_Projectile, transform.position, transform.rotation);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(player.transform.position.x, player.transform.position.y) * speed);

                cooldown = 3;
                

               
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
    
