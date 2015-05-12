using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelfDestruct : MonoBehaviour {

	public GameObject player;
	public GameObject boomText;
	

	public IEnumerator StartBoom()
	{

		yield return new WaitForSeconds (5.0f);
		Destroy (player);

		int size = Game_Controller.enemyList.Count;
		Debug.Log ("Size is " + size);
		GameObject[] copy = new GameObject[size];
		Game_Controller.enemyList.CopyTo (copy,0);

		for (int i = 0; i< size; i++) {
			Destroy (copy[i]);
			print("Destroyed");
		}

		boomText.SetActive (true);
		yield return new WaitForSeconds (2.0f);
		Application.LoadLevel (2);
	}

	public void Boom(){

		StartCoroutine (StartBoom ());
	}
}
