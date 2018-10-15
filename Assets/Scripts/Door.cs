using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (PlayerController.haveKey == "y")
        {
            Destroy(gameObject);
            PlayerController.haveKey = "n";
        }
    }
}
