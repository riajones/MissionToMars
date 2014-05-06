using UnityEngine;
using System.Collections;

public class farm : MonoBehaviour {
	bool placed = false;
	// Use this for initialization
	void Start () {
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().foodGrow += 1;
	}

	void Update () {
		if(placed == false){
			/*float x = Input.mousePosition.x;
			float y = 0.0f;
			float z = Input.mousePosition.z;
			Vector3 tempLoc = new Vector3(x,y,z);
			tempLoc = Camera.main.ScreenToWorldPoint(tempLoc);*/
			Vector3 tempLoc = Camera.main.transform.position;
			tempLoc.y -= Camera.main.transform.position.y;
			tempLoc.z += 15f;
			this.transform.position = tempLoc;
		}

	}
	void OnDestroy(){
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().foodGrow -= 1;
	}
	void OnMouseDown(){
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
	}
}
