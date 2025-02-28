using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{

    public float playerx;
    public float playery;

    public int health;
    public int coins;
    public bool axe;

    public TextMeshProUGUI coinText;
    public TextMeshProUGUI healthText;

    public static HUD hud;

    

    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else hud = this;
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        axe = false;
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = "Coins: "+coins;

        healthText.text = "HP: "+health;
    }
}
