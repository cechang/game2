using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	private Game_Controller gameController;

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
			//other.gameObject.LoseHealth();
			//if (other.gameObject.health == 0)
			// Destroy (other.gameObject);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
		worth = worth + gameController.GetChain();
		gameController.AddRep (worth);
		gameController.AddChain ();

	}

	void OnTriggerExit(Collider exit)
	{
		Destroy (gameObject);
		gameController.ResetChain ();
	}

	public static void Method()
	{
		Debug.Log ("Test");
	}

}
