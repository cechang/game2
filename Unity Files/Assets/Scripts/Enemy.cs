using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private Game_Controller gameController;
	private PlayerController playerController;

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

		rigidbody.velocity = transform.forward * -speed;
		worth = 1;
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
			worth = worth + gameController.GetChain();
			gameController.AddRep (worth);
			gameController.AddChain ();
		}

		if (other.tag == "Weapon") {

			Destroy (other.gameObject);
			Destroy (gameObject);
			worth = worth + gameController.GetChain ();
			gameController.AddRep (worth);
			gameController.AddChain ();
		}
	}

	void OnTriggerExit(Collider exit)
	{
		Destroy (gameObject);
		gameController.ResetChain ();
	}




}
