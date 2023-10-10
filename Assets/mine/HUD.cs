using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    public CoinScript purse;
    public Spikes healthPool;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: "+purse.Coins;

        healthText.text = "HP: "+healthPool.health;
    }
}
