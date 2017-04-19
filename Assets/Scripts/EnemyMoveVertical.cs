using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveVertical : MonoBehaviour {

    public float movementSpeed = 1.0f;
    public bool switchDirection;

    // Use this for initialization
    void Awake()
    {
        //transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

        if (switchDirection == true)
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }

        if (switchDirection == false)
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
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
