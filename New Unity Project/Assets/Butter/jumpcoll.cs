using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpcoll : MonoBehaviour
{

    public player thePlayer;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log("collided");
        if (coll.gameObject.tag == "Platform")
        {
            thePlayer.canjump = true;
        }
	}
}
