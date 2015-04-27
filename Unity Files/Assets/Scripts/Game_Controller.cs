using UnityEngine;
using System.Collections;

public class Game_Controller : MonoBehaviour
{
	public GameObject enemy;
	public Vector3 spawnValues;
	
	void Start ()
	{
		SpawnEnemy ();
	}
	
	void SpawnEnemy ()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (enemy, spawnPosition, spawnRotation);
	}
}