using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using Object = System.Object;

public class turret : MonoBehaviour
{
    public bool inRange;

    private bool buffer;
    private float bufferTimer;
    private float speed;
    private GameObject player;
    
    public GameObject turret_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
        speed = 2;
        bufferTimer = 0;
        buffer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (buffer)
        {
            if (inRange)
            {
                GameObject temp = Instantiate(turret_Projectile, transform.position, transform.rotation);
               // temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(player.transform.position.x, player.transform.position.y) * speed);

                bufferTimer = 3;

                if (buffer)
                {
                    bufferTimer -= Time.deltaTime;
                    if (bufferTimer < 0)
                    {
                        buffer = false;
                        bufferTimer = 1;
                    }
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            inRange = true;
        }
        
       
    }
}
    
