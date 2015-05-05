using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//singleton pattern

public class Game_Controller : MonoBehaviour
{
	public GameObject enemy;
	public GameObject player;
	public Vector3 spawnValues;
	public float spawnRate;
	public float countdown;
	public GUIText repText;
	public GUIText chainText;
	private int rep;
	private int chain;



	public int playerHealth;
	public int enemyHealth;





	void Start ()
	{
		StartCoroutine (SpawnEnemy ());
		rep = 0;
		chain = 0;
		CalcRep ();
		CalcChain ();
		 

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

	public int GetChain()
	{
		return chain;
	}

	public void AddRep (int repWorth)
	{
		rep = rep + repWorth;
		CalcRep ();
	}

	public void AddChain ()
	{
		chain = chain + 1;
		CalcChain ();
	}

	public void ResetChain()
	{
		chain = 0;
		CalcChain ();
	}

	void CalcRep()
	{
		repText.text = "Reputation: " + rep;
	}

	void CalcChain()
	{
		chainText.text = "Chain: " + chain;
	}
	



}