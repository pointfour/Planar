using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public Rigidbody2D rb;
    private float sidespeed = 3;
    public bool canjump = true;
    private float jumpStrength = 10;
    private float jumpRate = 0.25f;
    private float nextJump = 0;
    public GameObject[] Dims;
    public GameObject[] Platforms;

    // Use this for initialization
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Platforms = GameObject.FindGameObjectsWithTag("Platform");
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
        if (canjump && Input.GetKey(KeyCode.W) && Time.time > nextJump)
        {
            nextJump = Time.time + jumpRate;
            rb.velocity = new Vector2(rb.velocity.x, jumpStrength);
            canjump = false;
        }
    }

    public void SwitchDim(int dim)
    {
        for (int i = 0; i < Dims.Length; i++)
        {
            if (dim == i)
            {
                Dims[i].SetActive(true);
            }
            else
            {
                Dims[i].SetActive(false);
            }
        }
        foreach (GameObject platform in Platforms)
        {
            if (dim == 0)
            {
                platform.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
            }
            else if (dim == 1)
            {
                platform.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
            }
            else if (dim == 2)
            {
                platform.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
            }
        }
    }
}
