using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pets : MonoBehaviour {

	public string[] Pet;

	// Use this for initialization
	void Start () {

		Pet = new string [6];

		Pet[0] = "Cat";
		Pet[1] = "Dog";
		Pet[2] = "Fish";
		Pet[3] = "Snake";
		Pet[4] = "Bear";
		Pet[5] = "Spider";

		foreach(string item in Pet){
			print("I have a pet " + item);
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
