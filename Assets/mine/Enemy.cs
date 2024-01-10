using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public bool range;
    private GameObject player;
    
    public HUD hud;

    private Vector3 target;

    public int enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        

        enemySpeed = 4;

        range = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        target = GameObject.FindObjectOfType<PlayerMovement>().gameObject.transform.position;
        
        if (range)
        {
            enemySpeed = 4;

            var step = enemySpeed * Time.deltaTime;

            transform.position = Vector3.MoveTowards(transform.position, target, step);

            if (Vector3.Distance(transform.position, target) < 0.001f)
            {
                Destroy(gameObject);
            }


        }
    }

    void OnTriggerEnter2D(Collider2D other)
     {
         if (other.gameObject.CompareTag("Player"))
         {
             player = other.gameObject;
             range = true;
         }
     }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            range = false;
        }
    }
     
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            
                hud.health += -1;
            
        }
             
            
    }
}
