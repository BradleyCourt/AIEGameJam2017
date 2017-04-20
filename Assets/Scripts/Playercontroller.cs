using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public GameObject player;
    public float walkSpeed = 2.5f; // base walkspeed
    public float dash = 25.0f; // base dash speed
    private Vector3 move;
    public Vector3 growLarger;
    public int timesGrown;
    //private ItemAndWallSpawner Food = GetComponent<ItemAndWallSpawner>();

    private CharacterController cc;
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
        if(timesGrown <=10)
        {
            player.transform.localScale += growLarger;
            timesGrown++;
        }
        // after 10 food has been collected, dont grow in size 
        
    }
}
