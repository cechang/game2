using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Upgrade : MonoBehaviour {

	private Game_Controller gameController;
	public GameObject button1;
	public GameObject button2;
	public GameObject button3;
	public GameObject button4;
	public GameObject button5;
	public GameObject button6;
	public GameObject button7;
	public GameObject button8;
	public GameObject button9;
	public GameObject button10;
	public GameObject button11;
	public GameObject button12;
	public GameObject button13;
	public GameObject button14;
	public GameObject button15;
	public GameObject button16;
	public GameObject button17;
	public GameObject button18;
	public GameObject button19;
	public GameObject button20;

	private Button button1Script;
	private Button button2Script;
	private Button button3Script;
	private Button button4Script;
	private Button button5Script;
	private Button button6Script;
	private Button button7Script;
	private Button button8Script;
	private Button button9Script;
	private Button button10Script;
	private Button button11Script;
	private Button button12Script;
	private Button button13Script;
	private Button button14Script;
	private Button button15Script;
	private Button button16Script;
	private Button button17Script;
	private Button button18Script;
	private Button button19Script;
	private Button button20Script;

	void Start ()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent <Game_Controller> ();
		}
		if (gameController == null) {
			print ("Cannot find 'GameController' script");
		}

		button1Script = button1.GetComponent<Button> ();
		button2Script = button2.GetComponent<Button> (); 
		button3Script = button3.GetComponent<Button> (); 
		button4Script = button4.GetComponent<Button> (); 
		button5Script = button5.GetComponent<Button> (); 
		button6Script = button6.GetComponent<Button> (); 
		button7Script = button7.GetComponent<Button> (); 
		button8Script = button8.GetComponent<Button> (); 
		button9Script = button9.GetComponent<Button> (); 
		button10Script = button10.GetComponent<Button> (); 
		button11Script = button11.GetComponent<Button> (); 
		button12Script = button12.GetComponent<Button> (); 
		button13Script = button13.GetComponent<Button> (); 
		button14Script = button14.GetComponent<Button> (); 
		button15Script = button15.GetComponent<Button> (); 
		button16Script = button16.GetComponent<Button> (); 
		button17Script = button17.GetComponent<Button> (); 
		button18Script = button18.GetComponent<Button> ();
		button19Script = button19.GetComponent<Button> (); 
		button20Script = button20.GetComponent<Button> (); 

		if (gameController.bought1 == true) {
			button1Script.interactable = false;
		}
		if (gameController.bought2 == true) {
			button2Script.interactable = false;
		}
		if (gameController.bought3 == true) {
			button3Script.interactable = false;
		}
		if (gameController.bought4 == true) {
			button4Script.interactable = false;
		}
		if (gameController.bought5 == true) {
			button5Script.interactable = false;
		}
		if (gameController.bought6 == true) {
			button6Script.interactable = false;
		}
		if (gameController.bought7 == true) {
			button7Script.interactable = false;
		}
		if (gameController.bought8 == true) {
			button8Script.interactable = false;
		}
		if (gameController.bought9 == true) {
			button9Script.interactable = false;
		}
		if (gameController.bought10 == true) {
			button10Script.interactable = false;
		}
		if (gameController.bought11 == true) {
			button11Script.interactable = false;
		}
		if (gameController.bought12 == true) {
			button12Script.interactable = false;
		}
		if (gameController.bought13 == true) {
			button13Script.interactable = false;
		}
		if (gameController.bought14 == true) {
			button14Script.interactable = false;
		}
		if (gameController.bought15 == true) {
			button15Script.interactable = false;
		}
		if (gameController.bought16 == true) {
			button16Script.interactable = false;
		}
		if (gameController.bought17 == true) {
			button17Script.interactable = false;
		}
		if (gameController.bought18 == true) {
			button18Script.interactable = false;
		}
		if (gameController.bought19 == true) {
			button19Script.interactable = false;
		}
		if (gameController.bought20 == true) {
			button20Script.interactable = false;
		}

	}

	public void ShieldUpgrade1(){
		if (gameController.rep >= 100) {
			gameController.bonusHealth = 5;
			button1Script.interactable = false;
			gameController.rep -= 100;
			gameController.bought1 = true;
		}
	}

	public void ShieldUpgrade2(){
		if (gameController.rep >= 1000) {
			gameController.bonusHealth = 10;
			button2Script.interactable = false;
			button1Script.interactable = false;
			gameController.rep -= 1000;
			gameController.bought2 = true;
			gameController.bought1 = true;
		}
	}

	public void ShieldUpgrade3(){
		if (gameController.rep >= 10000) {
			gameController.bonusHealth = 15;
			button3Script.interactable = false;
			button2Script.interactable = false;
			button1Script.interactable = false;
			gameController.rep -= 10000;
			gameController.bought3 = true;
			gameController.bought2 = true;
			gameController.bought1 = true;
		}
	}

	public void ShieldUpgrade4(){
		if (gameController.rep >= 100000) {
			gameController.bonusHealth = 20;
			button4Script.interactable = false;
			button3Script.interactable = false;
			button2Script.interactable = false;
			button1Script.interactable = false;
			gameController.rep -= 100000;
			gameController.bought4 = true;
			gameController.bought3 = true;
			gameController.bought2 = true;
			gameController.bought1 = true;
		}
	}

	public void ShieldUpgrade5(){
		if (gameController.rep >= 1000000) {
			gameController.bonusHealth = 25;
			button5Script.interactable = false;
			button4Script.interactable = false;
			button3Script.interactable = false;
			button2Script.interactable = false;
			button1Script.interactable = false;
			gameController.rep -= 1000000;
			gameController.bought5 = true;
			gameController.bought4 = true;
			gameController.bought3 = true;
			gameController.bought2 = true;
			gameController.bought1 = true;
		}
	}

	public void AgilityUpgrade1(){
		if (gameController.rep >= 100) {
			gameController.bonusSpeed = 3;
			button6Script.interactable = false;
			gameController.rep -= 100;
			gameController.bought6 = true;
		}
	}

	public void AgilityUpgrade2(){
		if (gameController.rep >= 1000) {
			gameController.bonusSpeed = 6;
			button7Script.interactable = false;
			button6Script.interactable = false;
			gameController.rep -= 1000;
			gameController.bought7 = true;
			gameController.bought6 = true;
		}
	}

	public void AgilityUpgrade3(){
		if (gameController.rep >= 10000) {
			gameController.bonusSpeed = 9;
			button8Script.interactable = false;
			button7Script.interactable = false;
			button6Script.interactable = false;
			gameController.rep -= 10000;
			gameController.bought8 = true;
			gameController.bought7 = true;
			gameController.bought6 = true;
		}
	}

	public void AgilityUpgrade4(){
		if (gameController.rep >= 100000) {
			gameController.bonusSpeed = 12;
			button9Script.interactable = false;
			button8Script.interactable = false;
			button7Script.interactable = false;
			button6Script.interactable = false;
			gameController.rep -= 100000;
			gameController.bought9 = true;
			gameController.bought8 = true;
			gameController.bought7 = true;
			gameController.bought6 = true;
		}
	}

	public void AgilityUpgrade5(){
		if (gameController.rep >= 1000000) {
			gameController.bonusSpeed = 15;
			button10Script.interactable = false;
			button9Script.interactable = false;
			button8Script.interactable = false;
			button7Script.interactable = false;
			button6Script.interactable = false;
			gameController.rep -= 1000000;
			gameController.bought10 = true;
			gameController.bought9 = true;
			gameController.bought8 = true;
			gameController.bought7 = true;
			gameController.bought6 = true;
		}
	}

	public void PowerUpgrade1(){
		if (gameController.rep >= 100) {
			gameController.bonusPower = 1;
			button11Script.interactable = false;
			gameController.rep -= 100;
			gameController.bought11 = true;
		}
	}

	public void PowerUpgrade2(){
		if (gameController.rep >= 1000) {
			gameController.bonusPower = 2;
			button12Script.interactable = false;
			button11Script.interactable = false;
			gameController.rep -= 1000;
			gameController.bought12 = true;
			gameController.bought11 = true;
		}
	}

	public void PowerUpgrade3(){
		if (gameController.rep >= 10000) {
			gameController.bonusPower = 3;
			button13Script.interactable = false;
			button12Script.interactable = false;
			button11Script.interactable = false;
			gameController.rep -= 10000;
			gameController.bought13 = true;
			gameController.bought12 = true;
			gameController.bought11 = true;
		}
	}

	public void PowerUpgrade4(){
		if (gameController.rep >= 100000) {
			gameController.bonusPower = 4;
			button14Script.interactable = false;
			button13Script.interactable = false;
			button12Script.interactable = false;
			button11Script.interactable = false;
			gameController.rep -= 100000;
			gameController.bought14 = true;
			gameController.bought13 = true;
			gameController.bought12 = true;
			gameController.bought11 = true;
		}
	}

	public void PowerUpgrade5(){
		if (gameController.rep >= 1000000) {
			gameController.bonusPower = 5;
			button15Script.interactable = false;
			button14Script.interactable = false;
			button13Script.interactable = false;
			button12Script.interactable = false;
			button11Script.interactable = false;
			gameController.rep -= 1000000;
			gameController.bought15 = true;
			gameController.bought14 = true;
			gameController.bought13 = true;
			gameController.bought12 = true;
			gameController.bought11 = true;
		}
	}

	public void RankUpgrade1(){
		if (gameController.rep >= 1000) {
			gameController.bonusEnemyHealth = 1;
			gameController.bonusChain = 2;
			gameController.bonusWorth = 5;
			button16Script.interactable = false;
			gameController.rep -= 1000;
			gameController.bought16 = true;
		}
	}

	public void RankUpgrade2(){
		if (gameController.rep >= 10000) {
			gameController.bonusEnemyHealth = 2;
			gameController.bonusChain = 3;
			gameController.bonusWorth = 10;
			button17Script.interactable = false;
			button16Script.interactable = false;
			gameController.rep -= 10000;
			gameController.bought17 = true;
			gameController.bought16 = true;
		}
	}

	public void RankUpgrade3(){
		if (gameController.rep >= 100000) {
			gameController.bonusEnemyHealth = 3;
			gameController.bonusChain = 4;
			gameController.bonusWorth = 15;
			button18Script.interactable = false;
			button17Script.interactable = false;
			button16Script.interactable = false;
			gameController.rep -= 100000;
			gameController.bought18 = true;
			gameController.bought17 = true;
			gameController.bought16 = true;
		}
	}

	public void RankUpgrade4(){
		if (gameController.rep >= 1000000) {
			gameController.bonusEnemyHealth = 4;
			gameController.bonusChain = 5;
			gameController.bonusWorth = 20;
			button19Script.interactable = false;
			button18Script.interactable = false;
			button17Script.interactable = false;
			button16Script.interactable = false;
			gameController.rep -= 1000000;
			gameController.bought19 = true;
			gameController.bought18 = true;
			gameController.bought17 = true;
			gameController.bought16 = true;
		}
	}

	public void RankUpgrade5(){
		if (gameController.rep >= 10000000) {
			gameController.bonusEnemyHealth = 5;
			gameController.bonusChain = 6;
			gameController.bonusWorth = 25;
			button20Script.interactable = false;
			button19Script.interactable = false;
			button18Script.interactable = false;
			button17Script.interactable = false;
			button16Script.interactable = false;
			gameController.rep -= 10000000;
			gameController.bought20 = true;
			gameController.bought19 = true;
			gameController.bought18 = true;
			gameController.bought17 = true;
			gameController.bought16 = true;
		}
	}


}
