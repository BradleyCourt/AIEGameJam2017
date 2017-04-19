using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float walkSpeed = 2.5f;
    public float dash = 5.0f;
    Vector3 SlideDir;

        


	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Normal Movement
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * walkSpeed; // works with controller, wsad and arrow keys
        var z = Input.GetAxis("Vertical") * Time.deltaTime * walkSpeed;

        // Dashing
        if (Input.GetButtonDown("Space"))// when the spacebar is pressed, dash
        {
            x = Input.GetAxis("Horizontal") * Time.deltaTime * dash;
            z = Input.GetAxis("Horizontal") * Time.deltaTime * dash;
        }
        
	}
}
