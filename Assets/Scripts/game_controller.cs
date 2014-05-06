using UnityEngine;
using System.Collections;
using System;


public class game_controller : MonoBehaviour {

	//Functionallity Bools
	public bool movement;
	public bool isHud;

	//Timers
	public DateTime startTime;
	public DateTime updateTime;
	public DateTime disasterTime;
	private TimeSpan timeDif;


	//Resources
	public int atmosphere;
	public int population;
	public int ore;
	public int food;
	public int water;

	//Growth Rates
	public float atmosphereGrow;
	public float populationGrow;
	public float oreGrow;
	public float foodGrow;
	public float waterGrow;

	//Setup Variables
	public int disasterRate;



	void Start () {
		movement = true;
		isHud = true;
		startTime = System.DateTime.Now;
		updateTime = System.DateTime.Now;
		disasterTime = System.DateTime.Now;
		atmosphere = 0;
		population = 10;
		ore = 0;
		food = 0;
		water = 0;

		atmosphereGrow = 1f;
		populationGrow = 0f;
		oreGrow = 0f;
		foodGrow = 0f;
		waterGrow = 0f;
	

	
	}
	

	void Update () {
		//Checking for End Conditions
		if (atmosphere == 1000000)
			youWin ();
		if (population == 0)
			gameOver ();

		if(updateTime.Second >= 1){
			updateTime = System.DateTime.Now;
			atmosphere += (int)atmosphereGrow;
			population += (int)populationGrow;
			ore += (int)oreGrow;
			food += (int)foodGrow;
			water += (int)waterGrow;
			if (disasterTime.Minute >= 1) {
				int randNum = UnityEngine.Random.Range (0,50);
				if(randNum == 8){
					disasterStrikes();
					disasterTime = System.DateTime.Now;
				}
			}
		}


	}
	void disasterStrikes(){
		int randNum = UnityEngine.Random.Range (0,3);
		switch (randNum) {
		case 0://Generator Meltdown - Lose half of all resources
			atmosphere = atmosphere/2;
			population = population/2;
			ore = ore/2;
			food = food/2;
			water = water/2;
			break;
		case 1://Comet Strikes - Destroy all buildings in area around random point
			break;
		case 2:
			break;
		case 3:
			break;
		default:
			break;

		}
	}

	void gameOver(){
		movement = false;
		isHud = false;
		Camera.main.transform.position = new Vector3(500, 105, 500);
		Camera.main.transform.rotation = new Quaternion (00,-100,100,00);

	}
	void youWin(){

	}
}
