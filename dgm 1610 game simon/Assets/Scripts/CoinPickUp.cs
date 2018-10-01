﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int PointsToAdd;

	void OnTriggerEnter2D (Collider2D Other){
		if (Other.GetComponent<Rigidbody2D> () == null)
		return;

		ScoreManager.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}
}