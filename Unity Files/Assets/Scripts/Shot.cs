﻿using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour
{
	public float speed;
	
	void Start ()
	{
		rigidbody.velocity = transform.forward * speed;
	}
}
