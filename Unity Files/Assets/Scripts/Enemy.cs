using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Enemy : MonoBehaviour {
	private Game_Controller gameController;
	private PlayerController playerController;

	private int health;

	public float speed;
	public int worth;

	
	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent <Game_Controller>();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'GameController' script");
		}

		GameObject playerControllerObject = GameObject.FindWithTag ("Player");
		if (playerControllerObject != null)
		{
			playerController = playerControllerObject.GetComponent <PlayerController>();
		}
		if (playerController == null)
		{
			Debug.Log ("Cannot find 'PlayerController' script");
		}

		StartCoroutine (UpgradeEnemy ());

		rigidbody.velocity = transform.forward * -speed;
		worth = 1;
		health = gameController.enemyHealth;
	}
	

	void Update()
	{
		if (health == 0) {
			Destroy (gameObject);
			gameController.AddRep (worth + gameController.GetChain());
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
	}

	void LoseHealth()
	{
		health = health - 1;
	}

	//needs to be moved to gamecontroller
	IEnumerator UpgradeEnemy()
	{
		yield return new WaitForSeconds (2.0f);
		while (worth< 100) 
		{
			worth = worth + 5;
			health = gameController.enemyHealth + 1;
			yield return new WaitForSeconds (2.0f);
			Debug.Log ("worth went up");
		}
	}


}
