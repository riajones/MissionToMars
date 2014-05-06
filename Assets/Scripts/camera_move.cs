using UnityEngine;
using System.Collections;

public class camera_move : MonoBehaviour {
	public Vector3 cameraPos;
	public bool move;
	public GameObject gameController;

	void Start () {
		gameController = GameObject.Find ("Game_Controller");
	}
	

	void Update () {
		move = gameController.GetComponent<game_controller> ().movement;

		if(move){
			cameraPos = Camera.main.transform.position;
			//Iser is scrolling Back
			if (Input.GetAxis("Mouse ScrollWheel") < 0)
				cameraPos.y++;
			else if(Input.GetAxis ("Mouse ScrollWheel") > 0 && cameraPos.y > 10)
				cameraPos.y--;

			if(Input.mousePosition.x >= 790 && Camera.main.transform.position.x < 250)
				cameraPos.x++;
			else if(Input.mousePosition.x <= 10 && Camera.main.transform.position.x > -250)
				cameraPos.x--;
			if(Input.mousePosition.y >= 700 && Camera.main.transform.position.z < 250)
				cameraPos.z++;
			else if(Input.mousePosition.y <= 10 && Camera.main.transform.position.z > -250)
				cameraPos.z--;

			Camera.main.transform.position = cameraPos;
		}
	}
}
