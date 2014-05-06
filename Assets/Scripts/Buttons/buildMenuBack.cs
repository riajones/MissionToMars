using UnityEngine;
using System.Collections;

public class buildMenuBack : MonoBehaviour {

	void Start () {
	
	}

	void Update () {
	
	}

	//When the back button is pressed, return the camera to its previous position
	//re-enable movement
	//turn the hud back on
	void OnMouseDown(){
		GameObject buildIcon = GameObject.Find ("buildIcon");
		Camera.main.transform.position = buildIcon.GetComponent<build>().cameraWasHere;
		Camera.main.transform.rotation = buildIcon.GetComponent<build>().camRot;
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().movement = true;
		gameController.GetComponent<game_controller> ().isHud = true;

	}
}
