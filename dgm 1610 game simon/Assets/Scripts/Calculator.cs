using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//variables
	int number1;
	int number2;

	void start(){
		number1 = 5;
		number2 = 5;
		Debug.Log (number1 + number2);
	}
}
