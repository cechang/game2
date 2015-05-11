using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelfDestruct : MonoBehaviour {

	public GameObject player;
	

	public IEnumerator StartBoom()
	{

		yield return new WaitForSeconds (10.0f);
		Destroy (player);
		yield return new WaitForSeconds (2.0f);
		Application.LoadLevel (2);
		int size = Game_Controller.enemyList.Count;
		Debug.Log ("Size is " + size);
		GameObject[] copy = new GameObject[size];
		Game_Controller.enemyList.CopyTo (copy,size);

		for (int i = 0; i< size; i++) {
			Destroy (copy[i]);
		}


		/*
		 * int size = Game_Controller.enemyList.Count;
		for (int i = 0; i< size; i++) {
			Destroy (Game_Controller.enemyList<1>);
		}
		*/
		/*yield return new WaitForSeconds (3.0f);
		Destroy (player);

		yield return new WaitForSeconds (3.0f);
		Application.LoadLevel (2);
		*/

	}

	public void Boom(){

		StartCoroutine (StartBoom ());
	}
}
