using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDestroy : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hazard")
        {
           Debug.Log("collided");
            gameObject.SetActive(false);
            Destroy(other.gameObject);

        }

    }

}
