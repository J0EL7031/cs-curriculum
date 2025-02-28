using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TMPro.TextMeshProUGUI;

public class Spikes : MonoBehaviour
{
    public HUD hud;

    public bool iframes;
    private float iframesTimer;
    
    //public int health;
    // Start is called before the first frame update
    void Start()
    {
        hud.health = 10;
        hud = GameObject.FindObjectOfType<HUD>();
        iframesTimer = 1;
    }

    // Update is called once per frame3
    void Update()
    {
        if (hud.health < 1)
        {
            SceneManager.LoadScene("Overworld");
            hud.health = 10;
            hud.coins = 0;
        }

        if (iframes)
        {
            iframesTimer -= Time.deltaTime;
            if (iframesTimer < 0)
            {
                iframes = false;
                iframesTimer = 1;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
        {
             if (other.gameObject.CompareTag("Spikes"))
            {
                if (!iframes)
                {
                    iframes = true;
                    hud.health += -1;
                }
            }
             
             if (other.gameObject.CompareTag("Enemy"))
             {
                 if (!iframes)
                 {
                     iframes = true;
                     hud.health += -2;
                 }
             }
             
            
        }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("FireBall"))
        {
            if (!iframes)
            {
                iframes = true;
                Destroy(other.gameObject);
                hud.health += -1;
            }
        }
    }

}
