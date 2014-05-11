using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	// Use this for initialization
	GameObject gameController;

	void Start () {
		gameController = GameObject.Find ("Game_Controller");
	}
	
	// Update is called once per frame
	void Update () {	
	}

	//Start the game.
	void OnMouseDown(){
/*		if (this.gameObject.name == "B_People") {
			renderer.material.color = Color.green;
			gameController.GetComponent<game_controller>().population +=15;
			Debug.Log(gameController.GetComponent<game_controller>().population);
		}
*/
		if(this.gameObject.name=="B_Send"){
			Application.LoadLevel("MainGame");
			renderer.material.color = Color.green;
		}
	}

}
