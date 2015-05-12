using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
//singleton pattern


public class Game_Controller : MonoBehaviour
{
	public static Game_Controller instance = null; 

	public static LinkedList<GameObject> enemyList = new LinkedList<GameObject>();

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

	public int bonusHealth;
	public int bonusPower;
	public int bonusSpeed;
	public int bonusChain;
	public int bonusEnemyHealth;
	public int bonusWorth;
	
	public bool bought1;
	public bool bought2;
	public bool bought3;
	public bool bought4;
	public bool bought5;
	public bool bought6;
	public bool bought7;
	public bool bought8;
	public bool bought9;
	public bool bought10;
	public bool bought11;
	public bool bought12;
	public bool bought13;
	public bool bought14;
	public bool bought15;
	public bool bought16;
	public bool bought17;
	public bool bought18;
	public bool bought19;
	public bool bought20;

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
		bonusChain = 1;
		CalcRep ();
		CalcChain ();
		StartCoroutine (SpawnEnemy ());
		StartCoroutine (UpgradeEnemy ());
		 
	}

	void OnLevelWasLoaded(int level){
		GameObject repTextObject = GameObject.FindWithTag ("Score");
		if (repTextObject != null)
		{
			repText = repTextObject.GetComponent<GUIText> (); 
		}
		if (repText == null)
		{
			print ("Cannot find 'Reputation'" );
		}
		GameObject chainTextObject = GameObject.FindWithTag ("Chain");
		if (chainTextObject != null)
		{
			chainText = chainTextObject.GetComponent<GUIText> (); 
		}
		if (chainText == null)
		{
			print ("Cannot find 'Chain'");
		}

		if (level == 1){
			enemyHealth = 1;
			enemyWorth = 1;
			playerHealth = 5 + bonusHealth;
			chain = 0;
			CalcRep ();
		}

		CalcRep ();
		CalcChain ();
	}

	void Update(){
		if (Application.loadedLevel == 1|| Application.loadedLevel == 2) {
			CalcRep ();
		}

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
			print ("worth went up");
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