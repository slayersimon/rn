using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enoms : MonoBehaviour {

	enum Inventory {cheese, meat, sword, shield, map, backapck, bow, arrows};

	// Use this for initialization
	void Start () {

		print("Cheese = " + Inventory.cheese);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
