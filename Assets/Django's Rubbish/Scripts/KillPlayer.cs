using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{


    public GameObject deathParticles;
    public GameObject deathCanvas;

    //public int scoreValue;

    public int objectStrength;

    private GameControllerScript gameController;

    void Start()
    {

        GameObject gameControllerObject = GameObject.FindGameObjectWithTag("GameController");

        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameControllerScript>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }




    }


    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {

            Debug.Log("Enemy has collided with Player");



          gameController.GameOver();
            Debug.Log("Death canvas triggered");

           
        }



    }
}
