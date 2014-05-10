using UnityEngine;
using System.Collections;

public class expedPls : MonoBehaviour {

	void OnMouseDown(){
		GameObject lnchExped = GameObject.Find ("launchExpedition");
		GameObject gameController = GameObject.Find ("Game_Controller");
		if(lnchExped.GetComponent<launchExpedition> ().counter < gameController.GetComponent<game_controller>().population)
			lnchExped.GetComponent<launchExpedition> ().counter++;

	}
}
