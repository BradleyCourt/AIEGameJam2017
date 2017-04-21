using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour {

    public GameObject deathCanvas;
    public GameObject deathParticles;

   // public GUIText scoreText;
    //public GUIText restartText;
   // public GUIText gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;

    // Use this for initialization
    void Start()
    {
        gameOver = false;
        restart = false;
        //restartText.text = "";
        //gameOverText.text = "";
        score = 0;
        //UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void AddScore(int newScoreValue)
    //{
    //    UpdateScore();
    //    score += newScoreValue;
    //}

    //void UpdateScore()
    //{
    //    scoreText.text = "Score: " + score;
    //}

    public void GameOver()
    {
        finalParticle();
        Invoke("finalDeath", 2.0f);
    }

    void finalDeath()
    {
        deathCanvas.SetActive(true);
        //gameOverText.text = "Game Over!";
        gameOver = true;
    }

    void finalParticle()
    {
        deathParticles.SetActive(true);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        deathParticles.transform.position = player.transform.position;
        player.SetActive(false);
        //gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
