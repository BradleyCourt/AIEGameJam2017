using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    private Canvas gameOverCanvas;


    void start()
    {
        gameOverCanvas = FindObjectOfType<Canvas>();
    }

    void OnTriggerEnter(Collider other)

    {
        if (other.name == "Player")

        {
            Debug.Log("" + gameObject.name + " KILLED PLAYER");
            gameOverCanvas.enabled = true;
        }
    }
}
