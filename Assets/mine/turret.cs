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

    public GameObject turret_Projectile;
    // Start is called before the first frame update
    void Start()
    {
        inRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRange = true;
        }
        
        if (inRange = true)
        {
            Instantiate(turret_Projectile, transform.position, transform.rotation);
        }
    }
}
    
