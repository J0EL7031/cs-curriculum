using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector3 = System.Numerics.Vector3;

public class tp : MonoBehaviour
{

    public float rightLimit;
    public float leftLimit;

    public float speed;

    public int direction;

    public bool contact;

    // Start is called before the first frame update
    void Start()
    {
        contact = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (contact)
        {
            transform.position = new Vector2(90, 97);
        }

        if (contact != true)
        {
            transform.position = new Vector2(30, 30);
        }
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(transform);

            contact = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.transform.SetParent(null);
            
            contact = false;
        }
    }


}