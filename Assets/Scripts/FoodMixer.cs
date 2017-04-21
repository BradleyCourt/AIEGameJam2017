using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMixer : MonoBehaviour
{

    public GameObject donut;
    public GameObject fries;
    public GameObject cupcake;
    public GameObject chocolate;
    public GameObject icecream;
    public GameObject pie;
    public GameObject pizza;
    public GameObject steak;
    public GameObject ham;
    public GameObject burger;

    public int foodMixer;

    // Use this for initialization
    void Start ()
    { 
        foodMixer = 9;
    }
	
	// Update is called once per frame
	void Update ()
    {
		
        if (foodMixer == 0)
        {
            donut.SetActive(true);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 1)
        {
            donut.SetActive(false);
            fries.SetActive(true);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 2)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(true);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 3)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(true);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 4)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(true);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 5)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(true);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 6)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(true);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 7)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(true);
            ham.SetActive(false);
            burger.SetActive(false);
        }

        if (foodMixer == 8)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(true);
            burger.SetActive(false);
        }

        if (foodMixer == 9)
        {
            donut.SetActive(false);
            fries.SetActive(false);
            cupcake.SetActive(false);
            chocolate.SetActive(false);
            icecream.SetActive(false);
            pie.SetActive(false);
            pizza.SetActive(false);
            steak.SetActive(false);
            ham.SetActive(false);
            burger.SetActive(true);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foodMixer = GetRandomNumber(10);
            if (foodMixer == 0)
            {
                Debug.Log("donut spawns");
            }
            else if (foodMixer == 9)
            {
              Debug.Log("burger spawns");
            }
            else
            {
                Debug.Log("something else spawned");
            }
        }
    }

    //reset random number to zero
    int GetRandomNumber(int range)
    {
        return Random.Range(0, range);
    }

}
