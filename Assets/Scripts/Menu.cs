using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	GameObject gameController;

	void Start () {
		gameController = GameObject.Find ("Game_Controller");
	}
	
	// Update is called once per frame
	void Update () {	
	}
/*
	void Awake()
	{
		DontDestroyOnLoad(this);
	}
*/
	//This script is unfinished, for now it will only start the game.
	//Eventually it will selet button boxes and change variables
	void OnMouseDown(){
		if (this.gameObject.name == "B_People") {
			renderer.material.color = Color.green;
			gameController.GetComponent<game_controller>().population +=15;
			Debug.Log(gameController.GetComponent<game_controller>().population);
		}
		//Debug.Log ("population" +(gameController.GetComponent<game_controller>().population));
		//Debug.Log("The " + this.GameObject.name + " was clicked");
		if(this.gameObject.name=="B_Send"){
			Application.LoadLevel("MainGame");
			renderer.material.color = Color.green;
		}
	}

}
