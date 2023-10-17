using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public HUD hud;

    //public int coins;
    // Start is called before the first frame update
    void Start()
    {
        hud.coins = 0;
        hud = GameObject.FindObjectOfType<HUD>();
        print("Coins:"+hud.coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
             {
                 if (other.CompareTag("Coin"))
                 { 
                     hud.coins += 1;
                     other.gameObject.SetActive(false);
                     print("Coins:"+hud.coins);
                 }
             }
}
