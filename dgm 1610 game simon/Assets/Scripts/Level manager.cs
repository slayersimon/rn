using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//particles 
	public GameObject Deathparticle;
	public GameObject RespawnParticle;

	//Respawn delay
	public float RespawnDelay;

	//point penalty on death
	public int PointPenaltyOnDeath;

	//store Gravity Value
	private float GravityStore;

	//this is for initialization
	void start () {
		player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (deathparticle, player.transform.position, player.transform.rotation);
		//hide Player
		//player.enabled = false;
		player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		GravityStore = player.GetComponent<Rigidbody2D>().gravityScale;
	}
}