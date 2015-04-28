using UnityEngine;
using System.Collections;

public class Game_Controller : MonoBehaviour
{
	public GameObject enemy;
	public GameObject player;
	public Vector3 spawnValues;
	public float spawnRate;
	public float countdown;
	
	void Start ()
	{
		StartCoroutine (SpawnEnemy ());
	}
	
	IEnumerator SpawnEnemy ()
	{
		yield return new WaitForSeconds (countdown);
		while (player.activeSelf) {
			Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (enemy, spawnPosition, spawnRotation);
			yield return new WaitForSeconds (spawnRate);
		}
	}
}