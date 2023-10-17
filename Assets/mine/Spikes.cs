using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static TMPro.TextMeshProUGUI;

public class Spikes : MonoBehaviour
{
    public HUD hud;

    private bool iframes;
    private float iframesTimer;
    
    //public int health;
    // Start is called before the first frame update
    void Start()
    {
        hud.health = 10;
        hud = GameObject.FindObjectOfType<HUD>();
        iframesTimer = 3;
    }

    // Update is called once per frame
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
                iframesTimer = 3;
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
        }
    //my functins
  //  Void Death()
    //{
        
    //}

   // Void ChangeHealth(int amount)
    //{
        
    //}
}
