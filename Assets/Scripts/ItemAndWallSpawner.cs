﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAndWallSpawner : MonoBehaviour {

    public int score = 0;
    public Text scoreText;

    public GameObject food;
    public GameObject hazardHorizontal;
    public GameObject hazardVertical;
    public GameObject shieldIcon;
    public GameObject shieldBubble;

    public int shieldIconSpawner;
    public float shieldIconTimer;

    public int hazardSpawner;
    int spawnTimer;

    Playercontroller playerController;

    // Use this for initialization
    void Start ()
    {
        SetScoreText();
        score = 0;

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerController = player.GetComponent<Playercontroller>();
    }

    // Update is called once per frame
    void Update()
    {

        //Score Settings.
        scoreText.text = score.ToString();

        //Add 1 to Shield Icon Timer.
        /*shieldIconTimer += Time.deltaTime;

        //Switch Off Shield Icon.
        if (shieldIconSpawner > 0 && shieldIconTimer > 3)
        {
            shieldIconSpawner = 0;
            shieldIconTimer = 0;

        }

        //Spawn Shield Icon & Reset Shield Timer.
        if (shieldIconSpawner == 1 && shieldIconTimer > 0.1)
        {
            //Instantiate(shieldIcon);
            shieldIcon.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(3.5f, -3.5f), 0);
            shieldIconTimer = 0;*/


        //Spawn "Hazard" every "2" score (TURNED OFF)
        /*if (score %2 == 0)
        {
            hazardSpawner = GetRandomNumber(4);
        }*/


    
            //Switch off "Hazard" spawner.
            if (hazardSpawner > 0 && spawnTimer > 0.1)
            {
                hazardSpawner = 0;
                spawnTimer = 0;
            }

            //Spawn Hazard on Left Wall.
            if (hazardSpawner == 1)
            {
                Instantiate(hazardHorizontal);
                hazardHorizontal.transform.localPosition = new Vector3(-6.5f, Random.Range(4.5f, -4.5f), 0);
                spawnTimer++;

            }

            //Spawn Hazard on Right Wall.
            if (hazardSpawner == 2)
            {
                Instantiate(hazardHorizontal);
                hazardHorizontal.transform.localPosition = new Vector3(6.5f, Random.Range(4.5f, -4.5f), 0);
                spawnTimer++;

            }

            //Spawn Hazard on Top Wall.
            if (hazardSpawner == 3)
            {
                Instantiate(hazardVertical);
                hazardVertical.transform.localPosition = new Vector3(Random.Range(-4.8f, 4.8f), 4.5f, 0);
                spawnTimer++;

            }

            //Spawn Hazard on Bottom Wall.
            if (hazardSpawner == 4)
            {
                Instantiate(hazardVertical);
                hazardVertical.transform.localPosition = new Vector3(Random.Range(-4.8f, 4.8f), -4.5f, 0);
                spawnTimer++;

            }

        }
    

    void OnTriggerEnter(Collider other)
    {
        //Player collides with Food Item.
        if (other.tag == "Food")    
        {
            //Add 1 to score and relocate "Food" item randomly & Spawn a new "Hazard".
          
            food.transform.position = new Vector3(Random.Range(-4.5f, 4.5f), Random.Range(3.5f, -3.5f), 0);
            score = score + 100;
            playerController.Grow();
            hazardSpawner = GetRandomNumber(4);
            GetComponent<AudioSource>().Play();
            //shieldIconSpawner = GetRandomNumber(4);
        }

    }

    //Set Score.
    void SetScoreText()
    {
        scoreText.text = score.ToString();
    }

    //reset random number to zero
    int GetRandomNumber(int range)
    {
        return Random.Range(0, range);
    }

    


}
