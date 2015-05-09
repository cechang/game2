using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//singleton pattern

public class Game_Controller : MonoBehaviour
{
	public static Game_Controller instance = null; 

	public GameObject enemy;
	public GameObject player;
	public Vector3 spawnValues;
	public float spawnRate;
	public float countdown;
	public GUIText repText;
	public GUIText chainText;

	public int rep;
	public int chain;

	public int playerHealth;
	public int enemyHealth;
	public int enemyWorth;


	void Awake (){

		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);  
		DontDestroyOnLoad(gameObject);
	}


	void Start ()
	{
		rep = 0;
		chain = 0;
		CalcRep ();
		CalcChain ();
		StartCoroutine (SpawnEnemy ());
		StartCoroutine (UpgradeEnemy ());
		 

	}

	void OnLevelWasLoaded(int level){
		if (level == 1){
			enemyHealth = 1;
			enemyWorth = 1;
		}
	}

	void Update(){
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

	IEnumerator UpgradeEnemy()
	{
		yield return new WaitForSeconds (22.0f);
		while (enemyWorth < 100) 
		{
			enemyWorth = enemyWorth + 5;
			enemyHealth = enemyHealth + 1;
			yield return new WaitForSeconds (20.0f);
			Debug.Log ("worth went up");
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