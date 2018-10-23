using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Difficulty : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        PlayerController.gameDif = gameObject.name;
        Debug.Log(PlayerController.gameDif);
        SceneManager.LoadScene("Maze");
    }

   
}
