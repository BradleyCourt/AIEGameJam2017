using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

    public string startLevel;

    //public GameObject GameOverCanvas;
    


    public void NewGame()

    {
        SceneManager.LoadScene(startLevel);
    }

}
