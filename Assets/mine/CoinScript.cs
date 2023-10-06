using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public int Coins;
    
    // Start is called before the first frame update
    void Start()
    {
        Coins = 0;
        print("Coins:"+Coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
             {
                 if (other.CompareTag("Coin"))
                 { 
                     Coins += 1;
                     other.gameObject.SetActive(false);
                     print("Coins:"+Coins);
                 }
             }
}
