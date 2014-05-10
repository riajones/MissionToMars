using UnityEngine;
using System.Collections;

public class HUD_Controller : MonoBehaviour {
	//Declaring all the GameObject here to save a slight amount of computation
	//in the update function
	//public bool tab;
	public GameObject gameController;

	public GameObject HUD;
	public GameObject buildIcon;

	public GameObject popVal;
	public GameObject atmoVal;
	public GameObject oreVal;
	public GameObject foodVal;
	public GameObject waterVal;
	
	public GameObject popDisp;
	public GameObject atmoDisp;
	public GameObject oreDisp;
	public GameObject foodDisp;
	public GameObject waterDisp;


	void Start () {
		//tab = false;
		gameController = GameObject.Find ("Game_Controller");

		HUD = GameObject.Find ("HUD");
		buildIcon = GameObject.Find ("buildIcon");

		popVal = GameObject.Find ("popVal");
		atmoVal = GameObject.Find ("atmoVal");
		oreVal = GameObject.Find ("oreVal");
		foodVal = GameObject.Find ("foodVal");
		waterVal = GameObject.Find ("waterVal");

		popDisp = GameObject.Find ("popDisp");
		atmoDisp = GameObject.Find ("atmoDisp");
		oreDisp = GameObject.Find ("oreDisp");
		foodDisp = GameObject.Find ("foodDisp");
		waterDisp = GameObject.Find ("waterDisp");
	}
	
	void Update () {
		//Ensuring that all the HUD information is enabled if isHud is true
		//then updates all their values to the current values
		if(gameController.GetComponent<game_controller>().isHud){
			popDisp.guiText.enabled = true;
			atmoDisp.guiText.enabled = true;
			oreDisp.guiText.enabled = true;
			foodDisp.guiText.enabled = true;
			waterDisp.guiText.enabled = true;

			popVal.guiText.enabled = true;
			atmoVal.guiText.enabled = true;
			oreVal.guiText.enabled = true;
			foodVal.guiText.enabled = true;
			waterVal.guiText.enabled = true;

			HUD.guiTexture.enabled = true;
			buildIcon.guiTexture.enabled = true;
			string populationDisplay = gameController.GetComponent<game_controller> ().population.ToString() + " / " + gameController.GetComponent<game_controller>().maxPopulation.ToString();
			popVal.guiText.text = populationDisplay;


			atmoVal.guiText.text = gameController.GetComponent<game_controller> ().atmosphere.ToString();
			oreVal.guiText.text = gameController.GetComponent<game_controller> ().ore.ToString();
			foodVal.guiText.text = gameController.GetComponent<game_controller> ().food.ToString();
			waterVal.guiText.text = gameController.GetComponent<game_controller> ().water.ToString();
		}
		//If HUD is not enabled, disable all associated objects
		else{
			popDisp.guiText.enabled = false;
			atmoDisp.guiText.enabled = false;
			oreDisp.guiText.enabled = false;
			foodDisp.guiText.enabled = false;
			waterDisp.guiText.enabled = false;

			popVal.guiText.enabled = false;
			atmoVal.guiText.enabled = false;
			oreVal.guiText.enabled = false;
			foodVal.guiText.enabled = false;
			waterVal.guiText.enabled = false;
			
			HUD.guiTexture.enabled = false;
			buildIcon.guiTexture.enabled = false;
		}
	}

	/*
	void OnGUI(){
		Color textureColor = guiTexture.color;

		if (Input.GetKey ("tab")) {
						
			if (!tab) {
				textureColor.a = 0.2f;
				tab = true;
				Debug.Log("foo");
			}
			else if(tab)
			{
				textureColor.a = 0.0f;//transparent
				tab = false;
				Debug.Log("bar");
			}
		}
		guiTexture.color = textureColor;
	}
	 */

}
