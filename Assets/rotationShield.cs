using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationShield : MonoBehaviour {
    public float shieldSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up, shieldSpeed * Time.deltaTime);

    }
}
