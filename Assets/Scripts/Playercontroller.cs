using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float walkSpeed = 2.5f; // base walkspeed
    public float dash = 25.0f; // base dash speed


    private CharacterController cc;
    // Use this for initialization
    void Start ()
    {
        cc = GetComponent<CharacterController>();
    }
	
	// Update is called once per frame
	void Update ()
    {

        var currentV = cc.velocity;
        currentV.y = 0;

        Vector3 move;
        //Check for if the player is running
        if (Input.GetKey(KeyCode.LeftShift))
        {
            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * dash;
            currentV.x = move.x;
            currentV.z = move.z;
        }
        else
        {
            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * walkSpeed;
            currentV.x = move.x;
            currentV.z = move.z;
        }
        cc.Move(currentV * Time.deltaTime);
    }
}
