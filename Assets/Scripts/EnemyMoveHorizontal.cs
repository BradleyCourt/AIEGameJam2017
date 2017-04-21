using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveHorizontal : MonoBehaviour {

    public float movementSpeed = 1.0f;
    public bool switchDirection;

    public float rotateSpeed = 10f;

    // Use this for initialization
    void Awake()
    {
        //transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    } 

    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        if (switchDirection == true)
        {
            // Enemy Moves Left.
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        }

        if (switchDirection == false)
        {
            // Enemy Moves Right.
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);

        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            switchDirection = !switchDirection;
        }
    }

}
