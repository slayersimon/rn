using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {

	// playermovementvariables
	public int MoveSpeed;
	public float Jumpheight = 15;

	//player grounded variables
	public Transform Grundcheck;
	public float Groundcheckrarius;
	public LayerMask WhatIsGround;
	private bool Grounded; 

	// Use this for initialization
	void Start () {
		print("hello world");
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	Void FixedUpdate () (
		Grounded = Physics2D;OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	}
	// Update is called once per frame
		void Update () (

			//This code makes the character jump
			if(Input.GetKeyDown (KeyCode.Space)&& Grounded)(
				Jump();
		
		)
		Public void Jump()(
			GetComponent<Rigidbody2D>(.Velocity + new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight))
	}
}
