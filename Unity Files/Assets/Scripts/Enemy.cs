using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public float speed;
	
	void Start ()
	{
		rigidbody.velocity = transform.forward * -speed;
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
