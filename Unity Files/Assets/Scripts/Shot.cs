using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
	public float speed;
	public int power;


	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}
