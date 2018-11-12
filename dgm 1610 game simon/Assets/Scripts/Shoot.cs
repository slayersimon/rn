using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	//Shoot variables
	public Transform FirePoint;
	public GameObject Projectile;

	void Start(){
	Projectile = Resources.Load("prefab/Projectile") as GameObject;

	}
	//update is called once per frame
	void Update (){
		if(Input.GetKeyDown(KeyCode.RightControl))
		Instantiate(Projectile,FirePoint.position, FirePoint.rotation);

	}
}