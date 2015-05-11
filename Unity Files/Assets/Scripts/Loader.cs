using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour {

	public GameObject gameController;

	void Awake ()
	{
		if (Game_Controller.instance == null)
			Instantiate (gameController);

	}
}
