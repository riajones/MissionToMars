using UnityEngine;
using System.Collections;

public class HUD_Controller : MonoBehaviour {
	//Declaring all the GameObject here to save a slight amount of computation
	//in the update function
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
			popVal.guiText.enabled = true;
			atmoVal.guiText.enabled = true;
			oreVal.guiText.enabled = true;
			foodVal.guiText.enabled = true;
			waterVal.guiText.enabled = true;

			popVal.guiText.enabled = true;
			atmoVal.guiText.enabled = true;
			oreVal.guiText.enabled = true;
			foodVal.guiText.enabled = true;
			waterVal.guiText.enabled = true;

			HUD.guiTexture.enabled = true;
			buildIcon.guiTexture.enabled = true;

			popVal.guiText.text = gameController.GetComponent<game_controller> ().population.ToString();
			atmoVal.guiText.text = gameController.GetComponent<game_controller> ().atmosphere.ToString();
			oreVal.guiText.text = gameController.GetComponent<game_controller> ().ore.ToString();
			foodVal.guiText.text = gameController.GetComponent<game_controller> ().food.ToString();
			waterVal.guiText.text = gameController.GetComponent<game_controller> ().water.ToString();
		}
		//If HUD is not enabled, disable all associated objects
		else{
			popVal.guiText.enabled = false;
			atmoVal.guiText.enabled = false;
			oreVal.guiText.enabled = false;
			foodVal.guiText.enabled = false;
			waterVal.guiText.enabled = false;

			popVal.guiText.enabled = false;
			atmoVal.guiText.enabled = false;
			oreVal.guiText.enabled = false;
			foodVal.guiText.enabled = false;
			waterVal.guiText.enabled = false;
			
			HUD.guiTexture.enabled = false;
			buildIcon.guiTexture.enabled = false;
		}
	}

}
