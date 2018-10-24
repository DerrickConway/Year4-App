using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Back : MonoBehaviour {

	public void doBack()
    {
        //Debug.Log("Has quit Game");
         SceneManager.LoadScene("Difficulty");

        //Application.Quit();
    }
}
