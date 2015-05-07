using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {

	public GameObject player;
	public GameObject enemy;

	public void Boom(int i)
	{
		//yield return new WaitForSeconds (2.0f);
		//Destroy (player);
		//Destroy (enemy);
		//yield return new WaitForSeconds (2.0f);
		Application.LoadLevel (i);
	}
}
