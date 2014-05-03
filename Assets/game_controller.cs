using UnityEngine;
using System.Collections;
using System;


public class game_controller : MonoBehaviour {

	//Functionallity Bools
	public bool movement;

	//Timers
	public DateTime startTime;
	public DateTime curTime;
	private TimeSpan timeDif;					


	//Resources
	public int atmosphere;
	public int population;
	public int ore;
	public int food;
	public int water;

	//Growth Rates
	public int atmosphereGrow;
	public int populationGrow;
	public int oreGrow;
	public int foodGrow;
	public int waterGrow;

	//Game Object
	public GameObject camera = GameObject.Find ("Main Camera");



	void Start () {
		movement = true;
		startTime = System.DateTime.Now;
		curTime = System.DateTime.Now;
		atmosphere = 0;
		population = 10;
		ore = 0;
		food = 0;
		water = 0;

		atmosphereGrow = 1;
		populationGrow = 0;
		oreGrow = 0;
		foodGrow = 0;
		waterGrow = 0;
	

	
	}
	

	void Update () {
		//Checking for End Conditions
		if (atmosphere == 1000)
			youWin ();
		if (population == 0)
			gameOver ();

		if(curTime.Second >= 1){
			curTime = System.DateTime.Now;
			atmosphere += atmosphereGrow;
			population += populationGrow;
			ore += oreGrow;
			food += foodGrow;
			water += waterGrow;
		}

	}


	void gameOver(){
		movement = false;
		camera.transform = new Vector3 (500, 115, 500);

	}
	void youWin(){

	}
}
