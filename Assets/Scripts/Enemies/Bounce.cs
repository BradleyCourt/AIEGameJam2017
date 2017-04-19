using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb;

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Random.Range(0, 1.0f), 0, 1);
    }
	
	// Update is called once per frame
	void Update ()
    {
        float speed = rb.velocity.magnitude;
        if (speed < 5)
            rb.velocity = rb.velocity * (5 / speed);
	}

   /* void OnCollisionEnter(Collision collisionInfo)
    {
        Vector3 direction = rb.velocity;
        rb.velocity = Vector3.Reflect(direction, collisionInfo.contacts[0].normal);
        
    }*/
}
