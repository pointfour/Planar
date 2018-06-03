using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour
{

    public float ystart;
    public int dim;
    private float movement = 0.5f;
    private float rate = 2;
    // Use this for initialization
    void Start()
    {
        ystart = transform.position.y;
        movement = movement / 2;
        if (dim == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
        }
        else if (dim == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 1, 0);
        }
        else if (dim == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float offset = Mathf.Sin(Time.time * rate) * movement + movement;
        transform.position = new Vector2(transform.position.x, ystart + offset);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player"){
			coll.gameObject.GetComponent<player>().SwitchDim(dim);
        }
    }
}
