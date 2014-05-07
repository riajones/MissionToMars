using UnityEngine;
using System.Collections;

public class exploreBase : MonoBehaviour {
	bool placed = false;
	//When created the exploreBase increases the chances of success on
	//an expedition by 10% of the current success rate
	//NOTE: This effect does not end when the building is destroyed
	void Start () {
		GameObject gameController = GameObject.Find ("Game_Controller");
		gameController.GetComponent<game_controller> ().expeditionSuccessRate += gameController.GetComponent<game_controller> ().expeditionSuccessRate / 10;
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
			//Send the player to the launch expedition menu
			//I would like this to match the way that the player interacts with the other menus
			//we should decide if we want to send the player to the menu, or the menu to the player
			//and be consistent about it
		}
	}


}
