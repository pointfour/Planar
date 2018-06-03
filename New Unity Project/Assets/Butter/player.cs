using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rb;
    private float sidespeed = 3;
    public bool canjump = true;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-sidespeed, rb.velocity.y);
            Debug.Log("A" + rb.velocity);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(sidespeed, rb.velocity.y);
            Debug.Log("A" + rb.velocity);
        }
		
    }
}
