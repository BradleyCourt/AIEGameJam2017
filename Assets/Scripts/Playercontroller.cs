using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public GameObject player;


    //Player Movement
    private Vector3 move;
    public float walkSpeed = 2.5f; // base walkspeed
    public float dash = 25.0f; // base dash speed
  
    //Grow Related Code 
    public Vector3 growLarger;
    public int timesGrown;
    public int maxGrows;
    public int decreaseSpeed;

    //Character Controller
    private CharacterController cc;

    //Game States
    private bool gameOver;

    // Use this for initialization
    void Start ()
    {
        cc = GetComponent<CharacterController>();
        timesGrown = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        var currentV = cc.velocity;
        currentV.z = 0;

        //Check for if the player is running
        if (Input.GetKey(KeyCode.LeftShift))
        {
            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * dash;
            currentV.x = move.x;
            currentV.y = move.y;
        }
        else
        {
            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * walkSpeed;
            currentV.x = move.x;
            currentV.y = move.y;
        }
        cc.Move(currentV * Time.deltaTime);
    }
    public void Grow()
    {
        // if you collect food, increase scaling of player
        if(timesGrown < maxGrows)
        {
            player.transform.localScale += growLarger;
            walkSpeed -= decreaseSpeed;
            timesGrown++;
        }
        // after 10 food has been collected, dont grow in size 
        
    }
    public void Death()
    {

    }
}
