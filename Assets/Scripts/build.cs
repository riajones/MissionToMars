using UnityEngine;
using System.Collections;

public class build : MonoBehaviour {

	public Vector3 cameraWasHere;
	public Quaternion camRot;

	void Start () {
		
	}

	void Update () {

	}

	//When the player goes to the build screen
	//disable movement
	//turn off the HUD
	void OnMouseDown(){
		cameraWasHere = Camera.main.transform.position;
		camRot = Camera.main.transform.rotation;
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().movement = false;
		gameController.GetComponent<game_controller> ().isHud = false;

		Camera.main.transform.position = new Vector3(500, 108, 100);
		Camera.main.transform.rotation = new Quaternion (00,-100,100,00);
	}
}
