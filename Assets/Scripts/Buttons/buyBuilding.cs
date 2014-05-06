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
		GameObject buildIcon = GameObject.Find ("buildIcon");
		Camera.main.transform.position = buildIcon.GetComponent<build>().cameraWasHere;
		Camera.main.transform.rotation = buildIcon.GetComponent<build>().camRot;
		GameObject gameController = GameObject.Find ("Game_Controller");
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
