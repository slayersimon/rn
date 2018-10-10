using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public LevelManager LevelManager;

	// Use this for initialization
	void Start () {
		LevelManager = FindObjectOfType <LevelManager>();
	}

	void OnTriggerenter2D(Collider2D other){
		if(other.name == "player character"){
			LevelManager.RespawnPlayer();
		}
	}
}

