using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationShield : MonoBehaviour {
    public float shieldSpeed;

	// Use this for initialization
	void Start () {
        GetComponent<ParticleSystem>().Play();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate( 0.0f, 0.0f, shieldSpeed * Time.deltaTime);

    }
}
