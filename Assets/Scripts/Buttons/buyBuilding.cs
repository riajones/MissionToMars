using UnityEngine;
using System.Collections;

public class buyBuilding : MonoBehaviour {
	public GameObject building;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnMouseDown(){
		GameObject gameController = GameObject.Find ("Game_Controller");
		Camera.main.transform.position = gameController.GetComponent<game_controller> ().cameraWasHere;
		Camera.main.transform.rotation = gameController.GetComponent<game_controller> ().camRot;
		gameController.GetComponent<game_controller> ().movement = true;
		gameController.GetComponent<game_controller> ().isHud = true;
		
		Quaternion spawnRotation = new Quaternion (0, 0, 0, 0);
		
		float x = Input.mousePosition.x;
		float y = 0.0f;
		float z = Input.mousePosition.z;
		
		Vector3 spawnPos = new Vector3 (x, y, z);
		
		Instantiate (building, spawnPos, spawnRotation);
		
	}
	
}
