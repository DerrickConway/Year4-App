using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(PlayerController.gameDif == "Easy")
        {
            Destroy(gameObject);
        }

        if((PlayerController.gameDif == "Medium") &&(gameObject.name == "Key" || gameObject.name == "Door"))
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
