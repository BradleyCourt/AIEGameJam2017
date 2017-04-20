using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    public GameObject GameOverCanvas;


    void start()
    {
        GameOverCanvas = GameObject.FindGameObjectWithTag("GameOverCanvas");
    }

    void OnTriggerEnter(Collider other)

    {
        if (other.name == "Player")

        {
            Debug.Log("" + gameObject.name + " KILLED PLAYER");
            GameOverCanvas.SetActive(true);
        }
    }
}
