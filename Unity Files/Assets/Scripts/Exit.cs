using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	void OnTriggerExit(Collider obj)
	{
		Destroy (obj.gameObject);
	}
}
