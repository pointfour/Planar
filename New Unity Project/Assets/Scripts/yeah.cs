using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class yeah : MonoBehaviour
{
    float timeStamp = 0f;
    int dim = 0;
    // Use this for initialization
    void Start()
    {
        timeStamp = Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 7f, Input.GetAxis("Jump") * Time.deltaTime * 7f, 0f);
        if (timeStamp <= Time.time)
        {
            if (dim < 2)
            {
                if (Input.GetAxis("Dimension") > 0)
                {
                    transform.Translate(0f, 0f, 10f);
                    timeStamp = Time.time + 2f;
                    dim = dim + 1;
                }
            }
            if (dim > 0)
            {
                if (Input.GetAxis("Dimension") < 0)
                {
                    transform.Translate(0f, 0f, -10f);
                    timeStamp = Time.time + 2f;
                    dim = dim - 1;
                }
            }
        }
    }
}