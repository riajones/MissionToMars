using UnityEngine;
using System.Collections;

public class centralHUB : MonoBehaviour {
	bool placed;
	void start(){
		placed = true;
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
			//Send the player to the import from earth menu
			//Alternately move the imprt from earth menu to the player
		}
	}
}
