using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour {
float timeStamp = 0f;
	// Use this for initialization
	void Start () {
	timeStamp= Time.time;
	print (transform.position);
	}
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*7f,Input.GetAxis("Jump")*Time.deltaTime*7f,0f);
		if (timeStamp <= Time.time){
			if (Input.GetAxis("Dimension") > 0){
				if (transform.position.z<20){ 
					transform.Translate(0f,0f,10f);
					print(Input.GetAxis("Dimension"));
					timeStamp = Time.time+2f;
				}
			}
			if (Input.GetAxis("Dimension") < 0) {
				if (transform.position.z>0) {
					transform.Translate(0f,0f,-10f);
					print(Input.GetAxis("Dimension"));
					timeStamp = Time.time+2f;
				}
			}
		}
	}
}
