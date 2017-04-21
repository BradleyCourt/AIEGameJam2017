using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public GameObject Target;
    public float Rotate_X = 0;
    public float Rotate_Y = 0;
    public float Rotate_Z = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        //transform.rotation =  Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(Rotate_X, Rotate_Y, Rotate_Z) * Time.deltaTime);
        //Rotate(Rotate_X, Rotate_Y, Rotate_Z);
        // ...also rotate around the World's Y axis
        transform.Rotate(new Vector3(Rotate_X ,Rotate_Y, Rotate_Z)* Time.deltaTime, Space.World);

    }
}
