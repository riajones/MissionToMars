using UnityEngine;
using System.Collections;

public class exploreBase : MonoBehaviour {
	bool placed = false;
	public Vector3 cameraWasHere;
	public Quaternion camRot;

	//When created the exploreBase increases the chances of success on
	//an expedition by 10% of the current success rate
	//NOTE: This effect does not end when the building is destroyed
	void Start () {
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().expeditionSuccessRate += gameController.GetComponent<game_controller> ().expeditionSuccessRate / 10;
	}

	//While the building is being placed the update function causes its location to follow the mouse
	void Update () {
		if(placed == false){
			float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
			Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
			transform.position = new Vector3(pos_move.x, 0f, pos_move.z);
		}
	}

	void OnMouseDown(){
		//This is the code that executes when the building is placed
		if(placed == false){
			GameObject terrain = GameObject.Find ("Terrain");
			int x = (int)this.transform.position.x;
			int z = (int)this.transform.position.x;
			x += 250;
			z += 250;
			if(terrain.GetComponent<graph>().world[x,z].type == "dirt"){
				terrain.GetComponent<graph>().world[x,z].setType("building");
				placed = true;
			}
		}
		else{
			cameraWasHere = Camera.main.transform.position;
			camRot = Camera.main.transform.rotation;
			GameObject gameController = GameObject.Find ("Game_Controller");
			gameController.GetComponent<game_controller> ().movement = false;
			gameController.GetComponent<game_controller> ().isHud = false;
			GameObject lnchExped = GameObject.Find ("launchExpedition");
			lnchExped.GetComponent<launchExpedition>().onMenu = true;
			
			Camera.main.transform.position = new Vector3(-500, 608, 500);
			Camera.main.transform.rotation = new Quaternion (00,-100,100,00);
		}
	}


}
