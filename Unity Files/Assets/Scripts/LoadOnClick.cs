using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {

	public void LoadScene(int i)
	{
		Application.LoadLevel (i);
	}
}
