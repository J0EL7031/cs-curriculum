using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAxe : MonoBehaviour
{
    public HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Axe"))
        {

            hud.axe = true;
            
            Destroy(other.gameObject);
            
        }
    }
}
