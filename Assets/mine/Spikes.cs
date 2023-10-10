using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static TMPro.TextMeshProUGUI;

public class Spikes : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        //if (other.CompareTag())
        { 
            health += -1;
        }
    }
}
