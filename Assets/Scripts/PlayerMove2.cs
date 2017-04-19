using UnityEngine;
using System.Collections;

public class PlayerMove2 : MonoBehaviour {

   private CharacterController controller;
   private Vector3 moveVector;

    public float movementSpeed = 1.0f;

	// Use this for initialization
	void Start ()
    {
        controller = GetComponent<CharacterController>();
    }
	// Update is called once per frame
	void Update ()
    {
        moveVector = Vector3.zero;

        //Strafe Left or Right
        moveVector.x = Input.GetAxisRaw("Horizontal") * movementSpeed;

        //Move Up and Down
        moveVector.y = Input.GetAxisRaw("Vertical") * movementSpeed;

        //Move forward
        controller.Move(moveVector * Time.deltaTime);

        //TRANSFORM STYLE MOVEMENT (OLD CODE)
        //transform.position += (new Vector3(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"),0))*movementSpeed*Time.deltaTime;
    }
}
