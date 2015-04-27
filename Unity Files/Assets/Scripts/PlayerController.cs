using UnityEngine;
using System.Collections;

[System.Serializable]
public class Boundary
{
	public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
	public float speed;
	public float bank;
	public Boundary boundary;
	public GameObject laser;
	public Transform shotLocation;
	public float fireRate;
	private float nextShot;

	void Update ()
	{
		if (Input.GetButton ("Fire1") && Time.time > nextShot) {
			nextShot = Time.time + fireRate;
			Instantiate (laser, shotLocation.position, shotLocation.rotation);
		}
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * speed;
		
		rigidbody.position = new Vector3 
			(
				Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);
		
		rigidbody.rotation = Quaternion.Euler (-45-rigidbody.velocity.x * bank, 270.0f, 270.0f);
	}
}
