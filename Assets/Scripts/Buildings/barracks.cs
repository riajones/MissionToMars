using UnityEngine;
using System.Collections;

public class barracks : MonoBehaviour {
	bool placed = false;
	
	//Updates resource gather rate upon the creation of the object
	void Start () {
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().maxPopulation += 20;
	}
	
	//While the building is being placed the update function causes its location to follow the mouse
	void Update () {
		if(placed == false){
			float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
			Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));
			transform.position = new Vector3(pos_move.x, 0f, pos_move.z);
		}
	}
	//When the building is destroyed it stops producing resources
	void OnDestroy(){
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().maxPopulation -= 20;
	}
	//When the building is clicked on
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
	}
}