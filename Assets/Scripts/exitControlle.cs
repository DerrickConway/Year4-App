﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exitControlle : MonoBehaviour {

   // public Text winText;
	// Use this for initialization
	void Start () {
       // winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
           // winText.text = "You Win";
            Debug.Log("You win");
        }
    }
}
