﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {
	private Game_Controller gameController;
	private PlayerController playerController;

	private int health;

	public float speed;
	private int worth;

	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Game_Controller>();
		}
		if (gameController == null)
		{
			print ("Cannot find 'GameController' script");
		}

		GameObject playerControllerObject = GameObject.FindWithTag ("Player");
		if (playerControllerObject != null)
		{
			playerController = playerControllerObject.GetComponent <PlayerController>();
		}
		if (playerController == null)
		{
			print ("Cannot find 'PlayerController' script");
		}

		rigidbody.velocity = transform.forward * -speed;
		worth = gameController.enemyWorth;
		health = gameController.enemyHealth + gameController.bonusEnemyHealth;
	}

	void Awake(){
		Game_Controller.enemyList.AddLast (gameObject);
		print ("Added enemy to list");
	}
	

	void Update()
	{
		if (health <= 0) {
			Destroy (gameObject);
			gameController.AddRep (worth + gameController.bonusWorth + (gameController.GetChain() * gameController.bonusChain));
			gameController.AddChain ();
		}
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		if (other.tag == "Player") 
		{
			Destroy (gameObject);
			playerController.LoseHealth();
			gameController.AddRep (worth + gameController.GetChain());
			gameController.AddChain ();
		}

		if (other.tag == "Weapon") {

			Destroy (other.gameObject);
			LoseHealth();
		}
	}

	void OnTriggerExit(Collider exit)
	{
		Destroy (gameObject);
		gameController.ResetChain ();
		playerController.LoseHealth ();
	}

	void LoseHealth()
	{
		health = health - (1 + gameController.bonusPower);
	}

	void OnDestroy(){
		Game_Controller.enemyList.Remove (gameObject);
		print ("Removed enemy from list");
	}



}
