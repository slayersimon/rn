using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject CurrentCheckPoint;
	public Rigidbody2D Player;

	//particles 
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn delay
	public float RespawnDelay;

	//point penalty on death
	public int PointPenaltyOnDeath;

	//store Gravity Value
	private float GravityStore;

	//this is for initialization
	void start () {
		// player = FindObjectOfType<Rigidbody2D> ();
	}

	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//generate death particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//hide Player
		//player.enabled = false;
		Player.GetComponent<Renderer> ().enabled = false;
		// Gravity Reset
		GravityStore = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale = 0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//point penalty
		ScoreManager.AddPoints(-PointPenaltyOnDeath);
		//debug message
		Debug.Log ("Player Respawn");
		//Respawn Delay
		yield return new WaitForSeconds (RespawnDelay);
		//Gravity Restore
		Player.GetComponent<Rigidbody2D>().gravityScale = GravityStore;
		//Match players transform position
		Player.transform.position = CurrentCheckPoint.transform.position;
		//show player
		//player enabled = true;
		Player.GetComponent<Renderer> ().enabled = true;
		//spawn particle 
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
	}
}