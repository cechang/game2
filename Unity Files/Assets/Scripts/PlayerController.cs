﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	private Game_Controller gameController;
	public GameObject gameControll;

	public float speed;
	public float bank;
	public Boundary boundary;
	public GameObject laser;
	public Transform shotLocation;
	public float fireRate;
	private float nextShot;

	public Slider healthSlider;
	public GameObject gameOver;
	public GameObject restart;
	public GameObject sdButton;


	void Start() 
	{
		gameControll = GameObject.FindWithTag ("GameController");
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Game_Controller>();
		}
		if (gameController == null)
		{
			print ("Cannot find 'GameController' script");
		}

		healthSlider.value = gameController.playerHealth;
	}

	void Update ()
	{
		if ((Input.GetButton ("Jump")|| Input.GetButton ("Fire1")) && Time.time > nextShot) {
			nextShot = Time.time + fireRate;
			Instantiate (laser, shotLocation.position, shotLocation.rotation);
		}
		

		if (gameController.playerHealth <= 0) {
			Destroy(gameObject);
			gameOver.SetActive(true);
			restart.SetActive(true);
			sdButton.SetActive(false);
			Destroy(gameControll);

		}
	}
	

	public void LoseHealth()
	{
		gameController.playerHealth = gameController.playerHealth - 1;
		healthSlider.value = gameController.playerHealth;
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * (speed + gameController.bonusSpeed);
		
		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
		
		rigidbody.rotation = Quaternion.Euler (-45-rigidbody.velocity.x * bank, 270.0f, 270.0f);
	}
}
