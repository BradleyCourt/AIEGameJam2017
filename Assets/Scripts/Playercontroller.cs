using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class Playercontroller : MonoBehaviour
{
    public GameObject player;
    InputDevice device;

    //Player Movement
    private Vector3 move;
    public float walkSpeed = 2.5f; // base walkspeed
    public float dash = 25.0f; // base dash speed
  
    //Grow Related Code 
    public Vector3 growLarger;
    public int timesGrown;
    public int maxGrows;
    public float decreaseSpeed;

    //Powerup Related Code
    //public GameObject shield;

    //Dashing Related
    float dashingTimer = 0;
    float recharge = 0;
    public bool isDashing = false;

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
        device = InputManager.ActiveDevice;
            
        var currentV = cc.velocity;
        currentV.z = 0;

        bool wasDashing = isDashing;
        isDashing = false;
        //Check for if the player is running
        if ((Input.GetKey(KeyCode.Space) || InputManager.ActiveDevice.GetControl(InputControlType.Action3)) && dashingTimer <0.5f) 
        {
            dashingTimer += Time.deltaTime;
            isDashing = true;
            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * dash;
            currentV.x = move.x;
            currentV.y = move.y;
            if (!wasDashing)
            {
                recharge = 0;
            }

        }
        else
        {
            if (wasDashing)
            {
                dashingTimer = 0.5f;
            }

            move = (Input.GetAxisRaw("Horizontal") * transform.right + Input.GetAxisRaw("Vertical") * transform.forward) * walkSpeed;
            currentV.x = move.x;
            currentV.y = move.y;
        }
        recharge += Time.deltaTime;
        if (recharge > 5)
        {
            dashingTimer = 0;
        }
        wasDashing = isDashing;
        cc.Move(currentV * Time.deltaTime);
    }
    public void Grow()
    {
        // if you collect food, increase scaling of player
        if(timesGrown < maxGrows)
        {
            player.transform.localScale += growLarger;
            walkSpeed -= decreaseSpeed;
            dash -= decreaseSpeed *2;
            timesGrown++;
        }
        // after 10 food has been collected, dont grow in size 
        
    }
    public void Death()
    {

    }

    public void Shield()
    {

    }

    public void SugarRush()
    {

    }

}
