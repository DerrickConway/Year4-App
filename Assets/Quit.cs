using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour {

    public void doQuit()
    {
       Debug.Log("Has quit Game");
       // SceneManager.LoadScene("Menu");
       
        Application.Quit();
    }
}
